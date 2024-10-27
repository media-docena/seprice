using clinicaSePrice.Datos;
using clinicaSePrice.Entidades;
using clinicaSePrice.Utilidades;
using clinicaSePrice.ViewModels;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace clinicaSePrice
{
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void btnMenuPac_Click(object sender, EventArgs e)
        {
            // Retorna al menú al hacer click en el boton menú
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
        private void limpiarCasillas()
        {
            txtNombreP.Text = string.Empty;
            txtApeP.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtCorreoP.Text = string.Empty;
            txtTelP.Text = string.Empty;
            cboSexo.SelectedIndex = -1;
            dtpFecNacP.Text = string.Empty;
            cboCoberturaP.SelectedIndex = -1;
            txtNombreP.Focus();
        }

        private bool faltanCampos()
        {
            return (txtNombreP.Text.Trim() == string.Empty || txtApeP.Text.Trim() == string.Empty ||
                txtDNI.Text.Trim() == string.Empty || txtCorreoP.Text.Trim() == string.Empty ||
                txtTelP.Text.Trim() == string.Empty || cboSexo.Text == string.Empty
                || cboCoberturaP.Text == string.Empty);
        }

        private void registrarPaciente()
        {
            if (faltanCampos()) {

                MessageBox.Show("Todos los campos son requeridos", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else { // Si los campos son válidos se registra al paciente

                string respuesta;
                // Generamos una instancia con los datos proporcionados
                E_Paciente paciente = new E_Paciente
                {
                    Nombre = txtNombreP.Text,
                    Apellido = txtApeP.Text,
                    DNI = txtDNI.Text,
                    FecNac = DateOnly.FromDateTime(dtpFecNacP.Value),
                    Telefono = txtTelP.Text,
                    Correo = txtCorreoP.Text,
                    SexoPac = cboSexo.Text,
                    CoberturaPac = cboCoberturaP.Text.Equals("sí", StringComparison.OrdinalIgnoreCase)
                };

                // Pasamos los datos al método de paciente para registrarlo
                Paciente pacienteData = new Paciente();
                respuesta = pacienteData.NuevoPaciente(paciente);


                if (respuesta.Length > 0) {
                    MessageBox.Show("El paciente ya existe", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    limpiarCasillas();
                }
                else {
                    MessageBox.Show("Registro exitoso!!", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCasillas();
                }
            }

        }

        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            registrarPaciente();
        }

        private void cargarGrilla(string busqueda = "")
        {
            var dataPacientes = new Paciente();
            var listaP = dataPacientes.listar(busqueda);

            //*******************************************
            // Creamos una instancia Paciente view model 
            // para selecionar lo que queremos mostrar en la grilla
            //******************************************************
            var pacientesVM = listaP.Select(item => new PacienteVM
            {
                IdPaciente = item.IdPaciente,
                Nombre = item.Nombre,
                Apellido = item.Apellido,
                DNI = item.DNI,
                Fecha_Nac = item.FecNac,
                Telefono = item.Telefono,
                Correo = item.Correo,
                Sexo = item.SexoPac,
                Cobertura = item.CoberturaPac,
            }).ToList();

            dgvPacientes.DataSource = pacientesVM;
            // Ocultamos las columnas que no queremos que se vean
            dgvPacientes.Columns["IdPaciente"].Visible = false;
            dgvPacientes.Columns["Fecha_Nac"].Visible = false;
            dgvPacientes.Columns["Sexo"].Visible = false;
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBuscarP;
            cargarGrilla();
            // Seteamos el tipo de grilla que vamos a utilizar
            dgvPacientes.ImplementarConfiguracion("Solicitar Turno");
            
        }

        private void txtBuscarP_TextChanged(object sender, EventArgs e)
        {
            // Con txtBuscarP.Text obtenemos el término de búsqueda
            cargarGrilla(txtBuscarP.Text);
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //****************************************************
            // Al hacer click en el botón solicitar turno
            // obtenemos la columna seleccionada por su nombre
            // y luego la fila para pasar sus datos a PacientesVM
            //****************************************************
            if (dgvPacientes.Columns[e.ColumnIndex].Name == "ColumnaAccion") {
                var pacienteSeleccionado = (PacienteVM)dgvPacientes.CurrentRow.DataBoundItem;
                
                frmTurno frmTurno = new frmTurno { Paciente = pacienteSeleccionado };
                
                frmTurno.Show();
                this.Close();
            }
        }

        private void btnNuevoP_Click(object sender, EventArgs e)
        {
            txtNombreP.Focus();
        }
    }
}
