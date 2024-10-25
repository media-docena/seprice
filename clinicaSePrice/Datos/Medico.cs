using clinicaSePrice.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace clinicaSePrice.Datos
{
    public class Medico
    {
        // Metodo para obtener medicos con turno asignado en la DB.
        public List<E_Medico> ListarMedicosConTurno()
        {
            List<E_Medico> listaMedicos = new List<E_Medico>();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                MySqlCommand comando = new MySqlCommand("sp_buscarMedicosConTurno", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var medico = new E_Medico
                        {
                            Id = reader.GetInt32(0),
                            Usuario = null,
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            DNI = reader.GetString(3),
                            FecNac = DateOnly.FromDateTime(reader.GetDateTime(4)),
                            Telefono = reader.GetString(5),
                            Correo = reader.GetString(6),
                            Honorario = reader.GetFloat(7),
                        };
                        listaMedicos.Add(medico);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return listaMedicos;
        }

        // Metodo para obtener agenda diaria de un medico en una fecha determinada desde DB.
        public List<(int idTurno, TimeSpan inicioTurno, int idPaciente, string nombre, string apellido, string dni)> ObtenerAgendaDiaria(int idMedico, DateTime fecha)
        {
            List<(int idTurno, TimeSpan inicioTurno, int idPaciente, string nombre, string apellido, string dni)>? agendaDiaria = new List<(int, TimeSpan, int idPaciente, string, string, string)>();

            string query = "CALL sp_buscarAgendaDiaria(@idMedico, @fecha);";
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.Add("@idMedico", MySqlDbType.Int32).Value = idMedico;
                comando.Parameters.Add("@fecha", MySqlDbType.Date).Value = fecha;

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var registro = (
                            idTurno: reader.GetInt32("IdTurno"),
                            inicioTurno: (TimeSpan)reader.GetValue(reader.GetOrdinal("InicioTurno")),
                            idPaciente: reader.GetInt32("IdPaciente"),
                            nombre: reader.GetString("NomPac"),
                            apellido: reader.GetString("ApePac"),
                            dni: reader.GetString("DNIPac")
                        );
                        agendaDiaria.Add(registro);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return agendaDiaria;
        }

        public string VerificarEstadoTurno(int idTurno)
        {
            string salida = "";
            string query = "SELECT EstadoTurno FROM turno WHERE IdTurno = @IdTurnoForm;";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@IdTurnoForm", idTurno);
                object salidaScalar = comando.ExecuteScalar();
                string estadoActualizado = Convert.ToString(salidaScalar);
                if (estadoActualizado == "asignado")
                {
                    salida = "asignado";
                }
                else if (estadoActualizado == "cancelado")
                {
                    salida = "cancelado";
                }
                else
                {
                    salida = "confirmado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }

        public void ActualizarEstadoTurno(bool bandera, int idTurno)
        {
            string estadoTurno = VerificarEstadoTurno(idTurno);

            if (idTurno != 0)
            {
                if (estadoTurno == "asignado")
                {
                    string query = "UPDATE turno SET EstadoTurno = @Estado WHERE IdTurno = @IdTurnoForm;";
                    string Estado;
                    if (bandera == true)
                    {
                        Estado = "confirmado";
                    }
                    else
                    {
                        Estado = "cancelado";
                    }
                    MySqlConnection sqlCon = new MySqlConnection();
                    try
                    {
                        sqlCon = Conexion.getInstancia().CrearConexion();
                        sqlCon.Open();
                        MySqlCommand comando = new MySqlCommand(query, sqlCon);
                        comando.Parameters.AddWithValue("@Estado", Estado);
                        comando.Parameters.AddWithValue("@IdTurnoForm", idTurno);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("El cambio de estado del turno fue exitoso.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (sqlCon.State == ConnectionState.Open)
                        {
                            sqlCon.Close();
                        }
                    }
                }
                else { MessageBox.Show("El estado del turno ya fue modificado.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            }
            else
            {
                MessageBox.Show("Por favor, presione un check de la lista para continuar", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Metodo para verificar si el turno del paciente es apto para pago.
        public bool VerificarCoberturaPaciente(int idPaciente)
        {
            bool salida = false;
            string query = "SELECT CoberturaPac FROM paciente WHERE IdPaciente = @idPaciente;";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                object objectScalar = comando.ExecuteScalar();
                if (objectScalar != null)
                {
                    bool stringScalar = Convert.ToBoolean(objectScalar);
                    if (stringScalar == false)
                    {
                        salida = true;
                    }
                    else
                    {
                        MessageBox.Show("El paciente tiene cobertura medica, no es posible registrar el pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }

        // Metodo para verificar si que el turno no tenga un pago vinculado.
        public bool VerificarInexistenciaPago(int idTurno)
        {
            bool salida = false;
            string query = "SELECT IdPago FROM pago WHERE IdTurno = @idTurno;";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idTurno", idTurno);
                object objectScalar = comando.ExecuteScalar();
                if (objectScalar == null)
                {
                    salida = true;
                }
                else
                {
                    MessageBox.Show("El turno seleccionado ya tiene un pago registrado.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }

        // Metodo para devolver ultimo IDPAGO creado.
        private int BuscarUltimoIdPago()
        {
            int salida = 0;
            string query = "SELECT MAX(IdPago) FROM pago;";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                object objectScalar = comando.ExecuteScalar();
                if (objectScalar != null)
                {
                    salida = Convert.ToInt32(objectScalar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }

        // Metodo para buscar el honorario del medico en cuestion.
        public float BuscarMontoHonorario(int idMedico)
        {
            float salida = 0;
            string query = "SELECT Honorario FROM medico WHERE IdMedico = @idMedico;";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idMedico", idMedico);
                object objectScalar = comando.ExecuteScalar();
                if (objectScalar != null)
                {
                    salida = Convert.ToSingle(objectScalar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }

        // Metodo para registrar el pago del turno.
        public void RegistrarPago(int idTurno, int idPaciente, string metodoPago, float montoHonor)
        {
            int ultimoPago = BuscarUltimoIdPago();
            int nuevoPago = 0;

            DateTime fechaHoy = DateTime.Now;
            string concepto = "En concepto de atención médica";
            string query = "INSERT INTO pago (IdPaciente, IdTurno, FechaPago, MontoPago, FormaPago, DetallePago)" +
            "VALUES (@idPaciente, @idTurno, @fechaHoy, @montoHonor, @metodoPago, @concepto);";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                comando.Parameters.AddWithValue("@idTurno", idTurno);
                comando.Parameters.AddWithValue("@fechaHoy", fechaHoy);
                comando.Parameters.AddWithValue("@montoHonor", montoHonor);
                comando.Parameters.AddWithValue("@metodoPago", metodoPago);
                comando.Parameters.AddWithValue("@concepto", concepto);
                comando.ExecuteNonQuery();
                nuevoPago = BuscarUltimoIdPago();
                if (ultimoPago < nuevoPago) { MessageBox.Show("El registro del pago fue exitoso.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Error al registrar el pago.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
        }

        public List<(string Mes, int Anio, int IdMedico, string Nombre, string Apellido, string Especialidad, int CantConsultas, float HonorarioTotal)>
            ObtenerDatosHonorarios()
        {
            List<(string Mes, int Anio, int IdMedico, string Nombre, string Apellido, string Especialidad, int CantConsultas, float HonorarioTotal)> ListaHonorarios = new List<(string, int, int, string, string, string, int, float)>();
            string query = "SET lc_time_names = 'es_AR';" +
                "select monthname(curdate()) as Mes, Year(curdate()) as Anio, cm.IdMedico, m.Nombre, m.Apellido, " +
                "e.NomEspecial as Especialidad, count(cm.IdMedico) as Cant_consultas, (count(cm.IdMedico) * m.Honorario) as Honorario_Total " +
                "from consultaMedica cm inner join medico m on cm.IdMedico = m.IdMedico inner join especialidad e on m.IdEspecialidad = e.IdEspecialidad " +
                "where month(cm.FechaConsulta) = month(curdate()) and year(cm.FechaConsulta) = Year(curdate()) group by cm.IdMedico order by m.Apellido;";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var registro = (
                            Mes: reader.GetString("Mes"),
                            Anio: reader.GetInt32("Anio"),
                            IdMedico: reader.GetInt32("IdMedico"),
                            Nombre: reader.GetString("Nombre"),
                            Apellido: reader.GetString("Apellido"),
                            Especialidad: reader.GetString("Especialidad"),
                            CantConsultas: reader.GetInt32("Cant_consultas"),
                            HonorarioTotal: reader.GetFloat("Honorario_Total")
                            );
                        ListaHonorarios.Add(registro);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
            return ListaHonorarios;
        }

        public List<E_Medico> listarMedicos(int especialidad)
        {
            var listaMedicos = new List<E_Medico>();

            MySqlConnection sqlCon = new MySqlConnection();
            try {

                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("sp_listarMedicosSegunEspe", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("especialidad", MySqlDbType.Int32).Value = especialidad;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.Read()) {

                        var medico = new E_Medico
                        {
                            Id = reader.GetInt32(0),
                            Especialidad = new E_Especialidad
                            {
                                IdEspecialidad = reader.GetInt32(1),
                                Nombre = reader.GetString(2),
                            },
                            Nombre = reader.GetString(3),
                            Apellido = reader.GetString(4),
                            DNI = reader.GetString(5),
                            FecNac = DateOnly.FromDateTime(reader.GetDateTime(6)),
                            Telefono = reader.GetString(7),
                            Correo = reader.GetString(8),
                            Honorario = reader.GetFloat(9),
                        };

                        listaMedicos.Add(medico);
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
            return listaMedicos;
        }

        // Obtiene la lista de turnos disponibles según médico y fecha
        public List<E_Agenda> listarTurnos(int idMedico, DateOnly fecha) 
        {
            var listaTurnos = new List<E_Agenda>();
            MySqlConnection sqlCon = new MySqlConnection();
            try {

                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("sp_listarTurnosDisponibles", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("idMedico", MySqlDbType.Int32).Value = idMedico;
                comando.Parameters.Add("fecha", MySqlDbType.Date).Value = fecha;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.Read()) {
                        // Instanciamos cada turno disponible en la agenda médica
                        var turno = new E_Agenda
                        {
                            Id = reader.GetInt32(0),
                            Medico = new E_Medico
                            {
                                Id = reader.GetInt32(1),
                                Especialidad = new E_Especialidad
                                {
                                    IdEspecialidad = reader.GetInt32(2),
                                    Nombre = reader.GetString(3),
                                },
                                Nombre = reader.GetString(4),
                                Apellido = reader.GetString(5),
                                DNI = reader.GetString(6),
                                FecNac = DateOnly.FromDateTime(reader.GetDateTime(7)),
                                Telefono = reader.GetString(8),
                                Correo = reader.GetString(9),
                                Honorario = reader.GetFloat(10),
                            },
                            Fecha = DateOnly.FromDateTime(reader.GetDateTime(11)),
                            Inicio = TimeOnly.FromTimeSpan(reader.GetTimeSpan(12)),
                            Fin = TimeOnly.FromTimeSpan(reader.GetTimeSpan(13)),
                            Disponible = Convert.ToBoolean(reader.GetInt32(14)),
                        };

                        listaTurnos.Add(turno);
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
            return listaTurnos;

        }
    }
}
