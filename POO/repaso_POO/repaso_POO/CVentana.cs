namespace repaso_POO
{
    public enum VentanaCalidad { aluminio, madera, pvc };
    class Ventana : Tamanyo
    {
        VentanaCalidad calidad;

        public VentanaCalidad GetCalidad { get { return this.calidad; } }

        public Ventana(VentanaCalidad calidad) : base(60, 80)
        {
            this.calidad = calidad;
        }

        public Ventana(int ancho, int alto, VentanaCalidad calidad) : base(ancho, alto)
        {
            this.calidad = calidad;
        }
    }
}
