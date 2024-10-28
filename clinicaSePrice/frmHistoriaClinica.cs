using clinicaSePrice.Datos;
using clinicaSePrice.Entidades;
using clinicaSePrice.Utilidades;
using clinicaSePrice.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinicaSePrice
{
    public partial class frmHistoriaClinica : Form
    {
        public frmHistoriaClinica()
        {
            InitializeComponent();
        }

        private void btnMenuHC_Click(object sender, EventArgs e)
        {
            // Retornamos al menú
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private bool hayCamposVacios(params TextBox[] textBoxes)
        {
            return textBoxes.Any(tb => string.IsNullOrWhiteSpace(tb.Text));
        }

        private void limpiarCasillas(Control parent)
        {
            /*--------------------------------------------
             * El control padre que pasamos como parámetro
             * puede ser tanto un groupBox como un panel
             * --------------------------------------------*/
            foreach (Control control in parent.Controls) {
                if (control is TextBox textBox) {
                    textBox.Clear(); // Limpia el contenido del TextBox
                }
            }
        }

        private void btnRegistrarHC_Click(object sender, EventArgs e)
        {
            // Primero validamos que los campos no estén vacíos
            if (hayCamposVacios(txtDNIPac, txtAlergiaPac, txtMedicPac, txtEnfPac, txtAntecPac)) {
                MessageBox.Show("TODOS LOS CAMPOS SON REQUERIDOS", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else {
                var histClinica = new E_HistoriaClinica
                {
                    Alergias = txtAlergiaPac.Text,
                    Medicamentos = txtMedicPac.Text,
                    Enfermedades = txtEnfPac.Text,
                    AntecedentesF = txtAntecPac.Text,
                };

                var histClinicaData = new HistoriaClinica();
                var respuesta = histClinicaData.NuevaHistClinica(histClinica, txtDNIPac.Text);

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero) {
                    if (codigo == 0) {
                        MessageBox.Show("PACIENTE NO REGISTRADO", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        limpiarCasillas(grpNuevaHC);
                    }
                    else if (codigo == 1) 
                    {
                        MessageBox.Show("REGISTRO DE HISTORIA CLÍNICA EXITOSO!", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCasillas(grpNuevaHC);
                    }
                    else {
                        MessageBox.Show("REGISTRO DE HISTORIA CLÍNICA YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCasillas(grpNuevaHC);
                    }
                }
            }
        }

        private int calcularEdad(DateOnly fechaNacimiento, DateOnly fechaActual)
        {
            // Método auxiliar para calcular la edad del paciente
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustamos si aún no ha cumplido años este año
            if (fechaActual < fechaNacimiento.AddYears(edad)) {
                edad--;
            }

            return edad;
        }

        private void cargarGrilla(string busqueda = "")
        {

            var histClinicaData = new HistoriaClinica();
            var listaHistClinica = histClinicaData.listar(busqueda);
            DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now);
            //*******************************************
            // Creamos una instancia HistClinica view model 
            // para selecionar lo que queremos mostrar en la grilla
            //******************************************************
            var histClinicasVM = listaHistClinica.Select(item => new HistoriaClinicaVM
            {
                IdHC = item.IdHC,
                Paciente = item.Paciente,
                Nombre = item.Paciente?.Nombre,
                Apellido = item.Paciente?.Apellido,
                Edad = item.Paciente?.FecNac != null ? calcularEdad(item.Paciente.FecNac, fechaActual) : 0,
                DNI = item.Paciente?.DNI ?? "",
                Alergias = item.Alergias,
                Medicamentos = item.Medicamentos,
                Enfermedades = item.Enfermedades,
                Antecedentes = item.AntecedentesF,
                

                /*----------------------------------------------------------------------
                 * En la línea de edad se verifica que Paciente y FecNac no sean nulos 
                 * antes de llamar a la función calcularEdad. Si Paciente es nulo, se asignará 0 a Edad.
                 * -------------------------------------------------------------------------------------*/
            }).ToList();

            dgvHC.DataSource = histClinicasVM;
            // Ocultamos las columnas que no queremos que se vean
            dgvHC.Columns["IdHC"].Visible = false;
            dgvHC.Columns["Paciente"].Visible = false;
            dgvHC.Columns["Enfermedades"].Visible = false;
            dgvHC.Columns["Antecedentes"].Visible = false;

        }

        private void frmHistoriaClinica_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBuscarHC;
            cargarGrilla();
            //*********************************************
            // Implementamos una grilla custom y le pasamos 
            // como parámetro el tipo de botón que necesitamos
            //*********************************************
            dgvHC.ImplementarConfiguracion("Ver más");
            
        }

        private void btnNuevaHC_Click(object sender, EventArgs e)
        {
            txtDNIPac.Focus();
        }

        private void txtBuscarHC_TextChanged(object sender, EventArgs e)
        {
            /*------------------------------------------------------
             * Con txtBuscarHC.Text obtenemos el término de búsqueda
             * del placeholder del textBox
             * ----------------------------------------------------*/
            cargarGrilla(txtBuscarHC.Text);

        }

        private void dgvHC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //****************************************************
            // Al hacer click en el botón ver más
            // obtenemos la columna seleccionada por su nombre
            // y luego la fila para pasar sus datos a histClinicasVM
            //****************************************************
            if (dgvHC.Columns[e.ColumnIndex].Name == "ColumnaAccion") {
                var hcSeleccionada = (HistoriaClinicaVM)dgvHC.CurrentRow.DataBoundItem;
                var frmHistClinicaDetalle = new frmHistClinicaDetalle { HistClinica = hcSeleccionada };
                frmHistClinicaDetalle.Show();
                this.Close();
            }

        }
    }
}
