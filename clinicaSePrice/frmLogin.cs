using clinicaSePrice.Datos;
using System.Data;

namespace clinicaSePrice
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var correoUsu = txtCorreoLog.Text;
            var claveUsu = txtClave.Text;
            var rolUsu = cboRol.Text;

            // Validamos que los datos no estén vacíos
            if (correoUsu.Trim() == "" || claveUsu.Trim() == "" || rolUsu == "") {

                MessageBox.Show("Debe completar TODOS los campos para poder ingresar", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
                Usuario dataUsu = new Usuario();
                tablaLogin = dataUsu.Log_Usu(correoUsu, claveUsu, rolUsu);

                if (tablaLogin.Rows.Count > 0) {
                    // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                    MessageBox.Show("Ingreso exitoso", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // La siguiente línea permite tomar el dominio de la primera columna
                    // de la primera fila del resultado de la ejecucion de la query

                    Sesion.Usuario = Convert.ToString(tablaLogin.Rows[0][0]);
                    Sesion.Rol = rolUsu;

                    /*
                     Una vez que tenemos la conexión establecida PASAMOS al Menú PRINCIPAL
                     Se debe "Instanciar" un objeto de la clase formulario Menu
                     */
                    frmMenu menu = new frmMenu();
                    menu.Show(); // se llama al formulario del menú
                    this.Hide(); // ocultamos el formulario del login

                }
                else {
                    MessageBox.Show("Correo, rol y/o clave incorrecto", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
