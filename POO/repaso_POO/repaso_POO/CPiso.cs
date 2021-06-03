namespace repaso_POO
{
    class Piso //: Puerta
    {
        public int superficie;
        public Puerta[] puerta;
        public Ventana[] ventana;

        public Piso(int superficie, PuertaColor color)
        {
            for (int i = 0; i < 3; i++)
            {
                puerta[i] = new Puerta(color);
            }

            this.superficie = superficie;
        }
        public Piso(int superficie, Tamanyo[] tamanyo, PuertaColor color, Tamanyo[] tamanyo_ventanas, VentanaCalidad calidad)
        {
            //puertas = new Puertas(tamanyos);

            //this.superficie = superficie;

            this.superficie = superficie;

            puerta = new Puerta[tamanyo.Length];

            ventana = new Ventana[tamanyo_ventanas.Length];

            for (int i = 0; i < tamanyo.Length; i++)
            {
                puerta[i] = new Puerta(tamanyo[i].ancho, tamanyo[i].alto, color);
            }

            for (int i = 0; i < tamanyo_ventanas.Length; i++)
            {
                ventana[i] = new Ventana(tamanyo_ventanas[i].ancho, tamanyo_ventanas[i].alto, calidad);
            }
        }
    }
}
