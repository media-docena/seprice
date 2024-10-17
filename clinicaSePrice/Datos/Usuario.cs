using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Datos
{
    public class Usuario
    {
        public DataTable Log_Usu(string correo, string clave, string rol)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexión

                MySqlCommand comando = new MySqlCommand("sp_login", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("correo", MySqlDbType.VarChar).Value = correo;
                comando.Parameters.Add("clave", MySqlDbType.VarChar).Value = clave;
                comando.Parameters.Add("nomRol", MySqlDbType.VarChar).Value = rol;

                // abrimos la conexion
                sqlCon.Open();
                resultado = comando.ExecuteReader(); // almacenamos el resulatdo en la variable
                tabla.Load(resultado); // cargamos la tabla con el resultado
                return tabla;
                // de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL

            }
            catch (Exception ex) {
                throw;
            }
            // como proceso final
            finally {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); };
            }

        }
    }
}
