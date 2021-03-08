using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ejercicio_6_3_1
{
    class CPruerta
    {
        private int ancho;
        private int alto;
        public int color;
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
            if (ancho < 75 || ancho > 125)
                throw new Exception("Ancho de puerta incorrecto (75-125 cm).");

            this.ancho = ancho;
        }
        public void SetAlto(int alto)
        {
            if (alto < 205 || alto > 225)
                throw new Exception("Alto de puerta incorrecto (205-225 cm).");

            this.alto = alto;
        }
        public void MostrarEstado()
        {
            MessageBox.Show("Ancho: " + this.ancho +
                            "\nAlto: " + this.alto +
                            "\nColor" + this.color +
                            "\nAbierta: " + this.abierta);
        }
    }
}
