using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_7_1
{
    class CPersonaInglesa : CPersona
    {
        public string TomarTe()
        {
            return "Estoy tomando té";
        }
        public new string Saludar()
        {
            return base.Saludar("Inglesa");
        }
        public CPersonaInglesa(string nombre)
        {
            if (nombre == "")
            {
                base.SetNombre("John");
            }
            else
            {
                base.SetNombre(nombre);
            }
        }
    }
}
