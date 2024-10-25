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
    public class Turno
    {
        public string asignarTurno(int idPaciente,int idMedico, int idEspe, DateOnly fecTurno, TimeOnly inicioT, TimeOnly finT) 
        {
            string salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("sp_agendarTurno", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                
                comando.Parameters.Add("idPaciente", MySqlDbType.Int32).Value = idPaciente;
                comando.Parameters.Add("idMedico", MySqlDbType.Int32).Value = idMedico;
                comando.Parameters.Add("idEspe", MySqlDbType.Int32).Value = idEspe;
                comando.Parameters.Add("fecTurno", MySqlDbType.Date).Value = fecTurno;
                comando.Parameters.Add("inicioT", MySqlDbType.Time).Value = inicioT;
                comando.Parameters.Add("finT", MySqlDbType.Time).Value = finT;
                

                MySqlParameter parRta = new MySqlParameter();
                parRta.ParameterName = "rta"; 
                parRta.MySqlDbType = MySqlDbType.Int32;
                parRta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parRta);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(parRta.Value) ?? "";

            }
            catch (Exception ex) {
                salida = ex.Message;
            }
            finally {
                if (sqlCon.State == ConnectionState.Open) {
                    sqlCon.Close();
                }
            }
            return salida;

        }

        public string actualizarAgenda(int idAgenda) {
            string salida = "";
            string query = "update agenda set Disponible = 0 where IdAgenda = @idAgenda;";

            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idAgenda", idAgenda);
                object salidaScalar = comando.ExecuteScalar();
                string? agendaActualizada = Convert.ToString(salidaScalar);
                if (agendaActualizada != null) {
                    salida = "OK";
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
            return salida;

        }
    }
}
