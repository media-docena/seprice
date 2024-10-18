using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.ViewModels
{
    public class PacienteVM
    {
        public int IdPaciente { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public string? DNI { get; set; }
        public DateOnly? Fecha_Nac { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Sexo { get; set; }
        public Boolean Cobertura { get; set; }

    }
}
