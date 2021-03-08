using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_4_1
{
    class CPuerta
    {
        private int ancho;
        private int alto;
        private int color;
        private bool abierta;

        public void Abrir()
        {
            this.abierta = true;
        }
        public void Cerrar()
        {
            this.abierta = false;
        }
        public void SetAncho(int ancho)
        {
            this.ancho = ancho;
        }
        public void SetAlto(int alto)
        {
            this.alto = alto;
        }
        public void SetColor(int color)
        {
            this.color = color;
        }
        public string MostrarEstado()
        {
            return("Ancho: " + this.ancho +
                   "\nAlto: " + this.alto +
                   "\nColor" + this.color +
                   "\nAbierta: " + this.abierta);
        }
    }
}
