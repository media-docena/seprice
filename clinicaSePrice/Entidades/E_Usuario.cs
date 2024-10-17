using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Entidades
{
    public class E_Usuario
    {
        public int IdUsu { get; set; }
        public required E_Rol Rol { get; set; }
        public required string AliasUsu { get; set; }
        public required string Clave { get; set; }
        public Boolean? Activo { get; set; }

    }
}
