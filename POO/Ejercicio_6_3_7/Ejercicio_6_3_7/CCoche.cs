namespace Ejercicio_6_3_7
{
    class CCoche
    {
        private string marca;
        private string modelo;
        private int cilindrada;
        private float potencia;

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public void SetCilindrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
        }
        public void SetPotencia(float potencia)
        {
            this.potencia = potencia;
        }   
        public string GetMarca()
        {
            return this.marca;
        }
        public string GetModelo()
        {
            return this.modelo;
        }
        public int GetCilindrada()
        {
            return this.cilindrada;
        }
        public float GetPotencia()
        {
            return this.potencia;
        }
    }
}
