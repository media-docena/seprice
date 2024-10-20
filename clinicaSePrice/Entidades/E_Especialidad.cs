using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Entidades
{
    public class E_Especialidad
    {
        public int IdEspecialidad { get; set; }
        public required string Nombre { get; set; }
        public int Duracion { get; set; }
    }
}
