using clinicaSePrice.Datos;
using clinicaSePrice.Utilidades;
using clinicaSePrice.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinicaSePrice
{
    public partial class frmHistClinicaDetalle : Form
    {
        public required HistoriaClinicaVM HistClinica;
        public string correoMed = Sesion.Correo ?? "";
        public frmHistClinicaDetalle()
        {
            InitializeComponent();
        }

        private void btnMenuHCD_Click(object sender, EventArgs e)
        {
            // Retornamos al menú
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void llenarDatosPaciente()
        {
            lblDatoNom.Text = HistClinica.Paciente?.Nombre + " " + HistClinica.Paciente?.Apellido;
            lblDatoDNI.Text = HistClinica.Paciente?.DNI;
            lblDatoSexo.Text = HistClinica.Paciente?.SexoPac;
            lblDatoFeNac.Text = HistClinica.Paciente?.FecNac.ToString();
            lblDatoEdad.Text = HistClinica.Edad.ToString();
            txtAlergiaDPac.Text = HistClinica.Alergias;
            txtMedicDPac.Text = HistClinica.Medicamentos;
            txtEnfDatos.Text = HistClinica.Enfermedades;
            txtAntecedentesF.Text = HistClinica.Antecedentes;
        }
        private void cargarGrilla()
        {
            var consultaData = new ConsultaMedica();
            var listaConsultas = consultaData.traerConsultas(HistClinica.IdHC);

            var listaConsultasVM = listaConsultas.Select(item => new ConsultaMedicaVM
            {
                Id = item.Id,
                MedicoConsulta = item.Medico,
                Fecha = item.Fecha,
                Hora = item.Hora,
                Diagnostico = item.Diagnostico,
                Indicaciones = item.Indicaciones,
                Medico = item.Medico?.NombreCompleto,
                Especialidad = item.Medico?.Especialidad?.Nombre,

            }).ToList();

            dgvConsultaHC.DataSource = listaConsultasVM;
            dgvConsultaHC.Columns["Id"].Visible = false;
            dgvConsultaHC.Columns["HistClinica"].Visible = false;
            dgvConsultaHC.Columns["MedicoConsulta"].Visible = false;

            /*----------------------------------------------------------
            * La siguiente línea muestra mensaje de consultas no disponibles 
            * según la base de datos devuelva registros o no.
            *----------------------------------------------------------*/

            if (listaConsultas.Count == 0) {
                lblMensajeCM.Visible = true;
            }
            else {
                lblMensajeCM.Visible = false;
            }
        }

        private void btnVolverBuscarHC_Click(object sender, EventArgs e)
        {
            frmHistoriaClinica frm_histClinica = new frmHistoriaClinica();
            frm_histClinica.Show();
            this.Close();
        }

        private void frmHistClinicaDetalle_Load(object sender, EventArgs e)
        {
            llenarDatosPaciente();
            // Ocultamos mensaje de registros vacíos 
            lblMensajeCM.Visible = false;
            cargarGrilla();
            dgvConsultaHC.ImplementarConfiguracion("");
        }

        private bool faltanCampos()
        {
            return (txtIndicaciones.Text.Trim() == string.Empty || txtDiagnostico.Text.Trim() == string.Empty);
        }

        private void limpiarCasillas() 
        {
            txtDiagnostico.Text = string.Empty;
            txtIndicaciones.Text = string.Empty;
        }

        private void btnRegistrarCM_Click(object sender, EventArgs e)
        {
            if (faltanCampos()) 
            {
                MessageBox.Show("Todos los campos son requeridos", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else 
            {
                DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now);
                TimeOnly horaActual = TimeOnly.FromDateTime(DateTime.Now);
                var consultaMedData = new ConsultaMedica();
                string rta = consultaMedData.registrarConsulta(HistClinica.IdHC, correoMed, fechaActual, horaActual, txtDiagnostico.Text, txtIndicaciones.Text);

                bool esnumero = int.TryParse(rta, out int codigo);
                if (esnumero) {
                    if (codigo == 1) {
                        MessageBox.Show("Registro exitoso!", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCasillas();
                        cargarGrilla();
                    }
                    else {
                        MessageBox.Show("Hubo un problema con el registro de la consulta", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpiarCasillas();
                    }
                }
            }
        }
    }
}
