using clinicaSePrice.Entidades;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Datos
{
    public class Paciente
    {
        public object Nombre { get; internal set; }
        public int Id { get; internal set; }
        public string Apellido { get; internal set; }

        public string NuevoPaciente(E_Paciente paciente) {
            string salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("sp_nuevoPaciente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = paciente.Nombre;
                comando.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = paciente.Apellido;
                comando.Parameters.Add("DNI", MySqlDbType.VarChar).Value = paciente.DNI;
                comando.Parameters.Add("FecNac", MySqlDbType.VarChar).Value = paciente.FecNac.ToString("yyyy-MM-dd");
                comando.Parameters.Add("Telefono", MySqlDbType.VarChar).Value = paciente.Telefono;
                comando.Parameters.Add("Correo", MySqlDbType.VarChar).Value = paciente.Correo;
                comando.Parameters.Add("Sexo", MySqlDbType.VarChar).Value = paciente.SexoPac;
                comando.Parameters.Add("Cobertura", MySqlDbType.VarChar).Value = paciente.CoberturaPac? 1 : 0; // El ternario asigna el valor de tipo numérico
                                                                                                               // almacenado en la bd para el atributo booleano.

                MySqlParameter parRta = new MySqlParameter();
                parRta.ParameterName = "rta"; // asignamos el parámetro de respuesta que retorna el procedimiento
                parRta.MySqlDbType = MySqlDbType.VarChar; 
                parRta.Size = 100; // Ajustar el tamaño si es necesario
                parRta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parRta);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = parRta.Value.ToString() ?? "";
            }
            catch (Exception ex) {
                salida = ex.Message;
            }
            // como proceso final
            finally {
                if (sqlCon.State == ConnectionState.Open) {
                    sqlCon.Close();
                }
            }
            return salida;
        }

        public List<E_Paciente> listar(string pBuscado = "")
        {
            var listaPacientes = new List<E_Paciente>();

            MySqlConnection sqlCon = new MySqlConnection();

            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("sp_buscarPaciente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("busqueda", MySqlDbType.VarChar).Value = pBuscado;
                sqlCon.Open();

                // Leemos el resultado de la query ejecutada
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        // Instaciamos los pacientes de cada fila leída del reader
                        var paciente = new E_Paciente
                        {

                            IdPaciente = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            DNI = reader.GetString(3),
                            FecNac = DateOnly.FromDateTime(reader.GetDateTime(4)),
                            Telefono = reader.GetString(5),
                            Correo = reader.GetString(6),
                            SexoPac = reader.GetString(7),
                            CoberturaPac = Convert.ToBoolean(reader.GetInt32(8))
                        };

                        listaPacientes.Add(paciente);
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
            return listaPacientes;
        }
    } 
}
