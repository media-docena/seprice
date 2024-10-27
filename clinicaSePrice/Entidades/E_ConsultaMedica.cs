using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Entidades
{
    public class E_ConsultaMedica
    {
        public int Id { get; set; }
        public E_HistoriaClinica? HistClinica { get; set; }
        public E_Medico? Medico { get; set; }
        public DateOnly Fecha { get; set; }
        public TimeOnly Hora { get; set; }
        public required string Diagnostico { get; set; }
        public required string Indicaciones { get; set; }
    }
}
