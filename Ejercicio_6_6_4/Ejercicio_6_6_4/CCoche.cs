using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_6_4
{
    class CCoche : CVehiculo
    {
        int cantidadDeRuedas;

        public CCoche()
        {
            this.cantidadDeRuedas = 4;
        }

        public int GetRuedas()
        {
            return this.cantidadDeRuedas;
        }
        public void SetRuedas(int ruedas)
        {
            this.cantidadDeRuedas = ruedas;
        }
    }
}
