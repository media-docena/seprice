using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Entidades
{
    public class E_HistoriaClinica
    {
        public int IdHC { get; set; }
        public E_Paciente? Paciente { get; set; }
        public required string Alergias { get; set; }
        public required string Medicamentos { get; set; }
        public required string Enfermedades { get; set; }
        public required string AntecedentesF { get; set; }
    }
}
