using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Entidades
{
    public class E_Persona
    {
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string DNI { get; set; }
        public required DateOnly FecNac { get; set; }
        public required string Telefono { get; set; }
        public required string Correo { get; set; }

        // Metodo para concatenar nombre y apellido
        public string NombreCompleto
        {
            get { return $"{Nombre} {Apellido}"; }
        }
    }
}
