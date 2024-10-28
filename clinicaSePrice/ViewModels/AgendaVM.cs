using clinicaSePrice.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.ViewModels
{
    public class AgendaVM
    {
        public int Id { get; set; }
        public E_Medico? MedicoAgenda { get; set; }
        public required DateOnly Fecha { get; set; }
        public required TimeOnly Inicio { get; set; }
        public TimeOnly Fin { get; set; }
        public Boolean Disponible { get; set; }
        public string? Medico { get; set; }
        public string? Especialidad { get; set; }
        public TimeOnly Hora { get; set; }

    }
}
