using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Entidades
{
    public class E_Medico : E_Personal
    {
        private double _honorario;

        public double Honorario
        {
            get { return _honorario; }
            set
            {
                if (value <= 0) {
                    throw new ArgumentException("El honorario debe ser mayor a cero.");
                }
                _honorario = value;
            }
        }
    }
}
