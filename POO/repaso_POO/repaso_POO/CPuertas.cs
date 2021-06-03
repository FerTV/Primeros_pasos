using System;
using System.Collections.Generic;
using System.Text;

namespace repaso_POO
{
    class Puertas
    {
        public Puerta[] puerta;
        public int Length;

        public Puertas(int cantidad, PuertaColor color)
        {
            this.Length = cantidad;

            puerta = new Puerta[cantidad];

            for(int i=0; i < cantidad; i++)
            {
                puerta[i] = new Puerta(color);
            }
        }

        public Puertas(Tamanyo[] tamanyos, PuertaColor color)
        {
            this.Length = tamanyos.Length;

            puerta = new Puerta[tamanyos.Length];

            for(int i=0; i < tamanyos.Length; i++)
            {
                puerta[i] = new Puerta(tamanyos[i].ancho, tamanyos[i].alto, color);
            }
        }
    }
}
