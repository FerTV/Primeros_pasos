using System;
using System.Collections.Generic;
using System.Text;

namespace repaso_POO
{
    public enum PuertaColor { blanco, negro, nogal, pino };
    class Puerta : Tamanyo
    {
        PuertaColor color;

        public PuertaColor GetColor { get { return this.color; } }
        public Puerta(PuertaColor color) : base(80, 215)
        {
            this.color = color;
        }
        public Puerta(int ancho, int alto, PuertaColor color) : base(ancho ,alto)
        {
            this.color = color;
        }
    }
}
