using DotNetEnv;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;
        private Conexion() // asignamos valores a las variables de la conexion
        {
            // Cargar las variables de entorno desde el archivo .env
            Env.Load();
            this.baseDatos = Environment.GetEnvironmentVariable("DATABASE") ?? "";
            this.servidor = Environment.GetEnvironmentVariable("SERVER") ?? "";
            this.puerto = Environment.GetEnvironmentVariable("PORT") ?? "";
            this.usuario = Environment.GetEnvironmentVariable("USER") ?? "";
            this.clave = Environment.GetEnvironmentVariable("PASSWORD") ?? "";
        }
        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;

            }
            catch (Exception ex) {
                cadena = null;
                throw;
            }
            return cadena;
        }
        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            // Se puede crear la misma línea de arriba con compound assigment: con ??= new Conexion();
            return con;
        }
    }
}
