using clinicaSePrice.Entidades;
using clinicaSePrice.ViewModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Datos
{
    public class ConsultaMedica
    {
        public List<E_ConsultaMedica> traerConsultas(int idHistClinica) 
        {
            var listadoConsultas = new List<E_ConsultaMedica>();
            
            MySqlConnection sqlCon = new MySqlConnection();

            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand("sp_traerConsultas", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idHistClinica", idHistClinica);
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.Read()) {
                        var consulaMed = new E_ConsultaMedica
                        {
                            Id = reader.GetInt32(0),
                            Fecha = DateOnly.FromDateTime(reader.GetDateTime(1)),
                            Hora = TimeOnly.FromTimeSpan(reader.GetTimeSpan(2)),
                            Diagnostico = reader.GetString(3),
                            Indicaciones = reader.GetString(4),
                            Medico = new E_Medico
                            {
                                Id = reader.GetInt32(5),
                                Especialidad = new E_Especialidad
                                {
                                    IdEspecialidad = reader.GetInt32(6),
                                    Nombre = reader.GetString(7),
                                },
                                Nombre = reader.GetString(8),
                                Apellido = reader.GetString(9),
                                DNI = reader.GetString(10),
                                FecNac = DateOnly.FromDateTime(reader.GetDateTime(11)),
                                Telefono = reader.GetString(12),
                                Correo = reader.GetString(13),
                                Honorario = reader.GetFloat(14),
                            }
                        };

                        listadoConsultas.Add(consulaMed);
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
            return listadoConsultas;

        }

        public string registrarConsulta(int idHC, string correoMed, DateOnly fechaC, TimeOnly hora, string diagnostico, string indicaciones) 
        {

            string salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("sp_registrarConsulta", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idHC", MySqlDbType.Int32).Value = idHC;
                comando.Parameters.Add("correoMed", MySqlDbType.VarChar).Value = correoMed;
                comando.Parameters.Add("fechaC", MySqlDbType.Date).Value = fechaC;
                comando.Parameters.Add("hora", MySqlDbType.Time).Value = hora;
                comando.Parameters.Add("diagnostico", MySqlDbType.VarChar).Value = diagnostico;
                comando.Parameters.Add("indicaciones", MySqlDbType.VarChar).Value = indicaciones;
                

                MySqlParameter parRta = new MySqlParameter();
                parRta.ParameterName = "rta"; 
                parRta.MySqlDbType = MySqlDbType.VarChar;
                parRta.Size = 100; 
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
    }
}
