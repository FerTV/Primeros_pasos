using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_4_1
{
    class CPorton : CPuerta
    {
        public new void SetAncho(int ancho)
        {
            if (ancho < 75 || ancho > 90)
                throw new Exception("Ancho porton incorrecto (75-90 cm).");

            base.SetAncho(ancho);
        }
        public new void SetAlto(int alto)
        {
            if (alto < 40 || alto > 50)
                throw new Exception("Alto incorrecto (40-50 cm),");

            base.SetAlto(alto);
        }
    }
}
