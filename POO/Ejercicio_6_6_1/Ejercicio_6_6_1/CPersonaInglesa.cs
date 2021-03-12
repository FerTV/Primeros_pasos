using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_6_1
{
    class CPersonaInglesa : CPersona
    {
        public string TomarTe()
        {
            return "Estoy tomando té";
        }
        public new string Saludar()
        {
            return "I am " + base.GetNombre();
        }
        public CPersonaInglesa()
        {
            base.SetNombre("John");
        }
        public CPersonaInglesa(string nombre)
        {
            base.SetNombre(nombre);
        }
    }
}
