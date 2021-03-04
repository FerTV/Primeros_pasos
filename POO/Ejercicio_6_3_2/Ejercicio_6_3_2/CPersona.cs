using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ejercicio_6_3_2
{
    class CPersona
    {
        private string Nombre;
        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public void Saludar()
        {
            MessageBox.Show("Hola, soy " + this.Nombre);
        }
    }
}
