using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Entidades
{
    public class E_Agenda
    {
        public int Id { get; set; }
        public E_Medico? Medico { get; set; }
        public required DateOnly Fecha { get; set; }
        public required TimeOnly Inicio { get; set; }
        public TimeOnly Fin { get; set; }
        public Boolean Disponible { get; set; }
    }
}
