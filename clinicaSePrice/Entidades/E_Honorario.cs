using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Entidades
{
    public class E_Honorario
    {
        public int Id { get; set; }
        public E_Medico? Medico { get; set; }
        public E_Especialidad? Especialidad { get; set; }
        public required string Mes { get; set; }
        public required string Anio { get; set; }
        public int CantConsultas { get; set; }
        public double Monto { get; set; }
    }
}
