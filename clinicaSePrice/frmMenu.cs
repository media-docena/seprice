using clinicaSePrice.Datos;
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
    public partial class frmMenu : Form
    {
        private readonly string? _usuario = Sesion.Usuario;
        private readonly string? _rol = Sesion.Rol;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //**********************************************
            // Asignamos las variables de sesión del usuario
            // al cargar el formulario del Menú
            //**********************************************
            initSesionUsu();
            ocultarAccesos();
        }

        private void initSesionUsu()
        {
            lblNomUsu.Text = _usuario;
            lblRol.Text = _rol;
        }

        private void ocultarAccesos()
        {
            //*************************************
            // Si el usuario logueado es Admin
            // ocultamos el acceso a la funcionalidad
            // de la Historia Clínica si es Medico,
            // se oculta el acceso a Honorarios.
            //**************************************
            if (_rol == "Administrador")
            {
                btnHC.Visible = false;
            }
            else
            {
                btnHonorarios.Visible = false;
            }
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            // Pasamos al formulario del paciente 
            // para luego tomar el turno
            frmPaciente menu = new frmPaciente();
            menu.Show();
            this.Hide();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda form = new frmAgenda();
            form.Show();
            this.Hide();
        }

        private void btnHonorarios_Click(object sender, EventArgs e)
        {
            frmHonorario form = new frmHonorario();
            form.Show();

        private void btnHC_Click(object sender, EventArgs e)
        {
            // Pasamos al formulario de la hist. clínica
            frmHistoriaClinica histClinica = new frmHistoriaClinica();
            histClinica.Show();
            this.Hide();
        }
    }
}
