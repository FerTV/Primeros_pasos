using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_7_1
{
    class CPersona
    {
        private string Nombre;
      
        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public string GetNombre()
        {
            return this.Nombre;
        }
        public string Saludar()
        {
            return ("Hola, soy " + this.Nombre);
        }
        public string Saludar(string tipo)
        {
            if(tipo=="Inglesa")
            {
                return "I am " + this.GetNombre();
            }
            else if(tipo=="Italiana")
            {
                return "Ciao";
            }
            else
            {
                return ("Hola, soy " + this.Nombre);
            }
        }
    }
}
