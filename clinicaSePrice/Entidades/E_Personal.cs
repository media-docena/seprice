using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Entidades
{
    public abstract class E_Personal : E_Persona
    {
        public int Id { get; set; }
        public E_Usuario? Usuario { get; set; }
    }
}
