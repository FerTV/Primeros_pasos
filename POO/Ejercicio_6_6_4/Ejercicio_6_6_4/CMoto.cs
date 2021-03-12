using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_6_4
{
    class CMoto : CVehiculo
    {
        int cantidadDeRuedas;

        public CMoto()
        {
            this.cantidadDeRuedas = 2;
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
