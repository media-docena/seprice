using clinicaSePrice.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Datos
{
    public class Especialidad
    {
        public List<E_Especialidad> listarEspecialidades() 
        {
            var especialidades = new List<E_Especialidad>();
            MySqlConnection sqlCon = new MySqlConnection();
            try {
                
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "select IdEspecialidad, NomEspecial from especialidad;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
     
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.Read()) {

                        var especialidad = new E_Especialidad
                        {
                            IdEspecialidad = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                        };

                        especialidades.Add(especialidad);
                    }
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (sqlCon.State == ConnectionState.Open) {
                    sqlCon.Close();
                }
            }
            return especialidades;
        }
    }
}
