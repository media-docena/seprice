using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Entidades
{
    public class E_Paciente : E_Persona
    {
        public int IdPaciente { get; set; }
        public required string SexoPac { get; set; }
        public required Boolean CoberturaPac { get; set; }
    }
}
