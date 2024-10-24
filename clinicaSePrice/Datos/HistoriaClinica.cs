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
    public class HistoriaClinica
    {
        public string NuevaHistClinica(E_HistoriaClinica histClinica, string dniPaciente) 
        {
            string salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try 
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("sp_crearHistClinica", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("DNIP", MySqlDbType.VarChar).Value = dniPaciente;
                comando.Parameters.Add("Alergias", MySqlDbType.VarChar).Value = histClinica.Alergias;
                comando.Parameters.Add("Medicamentos", MySqlDbType.VarChar).Value = histClinica.Medicamentos;
                comando.Parameters.Add("Enfermedades", MySqlDbType.VarChar).Value = histClinica.Enfermedades;
                comando.Parameters.Add("Antecedentes", MySqlDbType.VarChar).Value = histClinica.AntecedentesF;

                MySqlParameter parRta = new MySqlParameter();
                parRta.ParameterName = "rta"; // asignamos el parámetro de respuesta que retorna el procedimiento
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

        public List<E_HistoriaClinica> listar(string histClincaBuscada = "") 
        { 
            var listaHistClinica = new List<E_HistoriaClinica>();

            MySqlConnection sqlCon = new MySqlConnection();

            try {

                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("sp_buscarHistClinica", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("busqueda", MySqlDbType.VarChar).Value = histClincaBuscada;
                sqlCon.Open();

                // Leemos el resultado de la query ejecutada
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        // Instaciamos las hist. clínicas de cada fila leída del reader
                        var histClinica = new E_HistoriaClinica
                        {
                            IdHC = reader.GetInt32(0),
                            Paciente = new E_Paciente
                            {
                                IdPaciente = reader.GetInt32(1),
                                Nombre = reader.GetString(2),
                                Apellido = reader.GetString(3),
                                DNI = reader.GetString(4),
                                FecNac = DateOnly.FromDateTime(reader.GetDateTime(5)),
                                Telefono = reader.GetString(6),
                                Correo = reader.GetString(7),
                                SexoPac = reader.GetString(8),
                                CoberturaPac = Convert.ToBoolean(reader.GetInt32(9))
                            },
                            Alergias = reader.GetString(10),
                            Medicamentos = reader.GetString(11),
                            Enfermedades = reader.GetString(12),
                            AntecedentesF = reader.GetString(13),
                        };


                        // Agregamos cada instancia a la lista 
                        listaHistClinica.Add(histClinica);
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
            return listaHistClinica;
        }
    }
}
