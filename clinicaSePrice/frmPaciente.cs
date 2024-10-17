using clinicaSePrice.Datos;
using clinicaSePrice.Entidades;
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
            this.Close();
        }
        private void limpiarCasillas()
        {
            txtNombreP.Text = string.Empty;
            txtApeP.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtCorreoP.Text = string.Empty;
            txtTelP.Text = string.Empty;
            txtSexo.Text = string.Empty;
            dtpFecNacP.Text = string.Empty;
            cboCoberturaP.Text = string.Empty;
            txtNombreP.Focus();
        }

        private bool faltanCampos()
        {
            return (txtNombreP.Text == string.Empty || txtApeP.Text == string.Empty || txtDNI.Text == string.Empty
                || txtCorreoP.Text == string.Empty || txtTelP.Text == string.Empty || txtSexo.Text == string.Empty
                || cboCoberturaP.Text == string.Empty);
        }

        private void registrarPaciente()
        {
            if (faltanCampos()) { 

                MessageBox.Show("TODOS LOS CAMPOS SON REQUERIDOS", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
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
                    SexoPac = txtSexo.Text,
                    CoberturaPac = cboCoberturaP.Text.Equals("sí", StringComparison.OrdinalIgnoreCase)

                };

                // Pasamos los datos al método de paciente para registrarlo
                Paciente pacienteData = new Paciente();
                respuesta = pacienteData.NuevoPaciente(paciente);


                if (respuesta.Length > 0) {
                    MessageBox.Show($"{respuesta}", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    limpiarCasillas();
                }
                else {
                    MessageBox.Show("REGISTRO EXITOSO!!", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCasillas();
                }
            }

        }

        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            registrarPaciente();
        }
    }
}
