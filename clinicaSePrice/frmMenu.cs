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
            ocultarHC();
        }

        private void initSesionUsu()
        {
            lblNomUsu.Text = _usuario;
            lblRol.Text = _rol;
        }

        private void ocultarHC() 
        {
            //*************************************
            // Si el usuario logueado es Admin
            // ocultamos el acceso a la
            // funcionalidad de la Historia Clínica
            //**************************************
            if (_rol == "Administrador") {
                btnHC.Visible = false;
            }
        }
    }
}
