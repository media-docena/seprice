using clinicaSePrice.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.ViewModels
{
    public class HistoriaClinicaVM
    {
        public int IdHC { get; set; }
        public E_Paciente? Paciente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Edad { get; set; }
        public required string DNI { get; set; }
        public required string Alergias { get; set; }
        public required string Medicamentos { get; set; }
        public required string Enfermedades { get; set; }
        public required string Antecedentes { get; set; }
        
    }
}
