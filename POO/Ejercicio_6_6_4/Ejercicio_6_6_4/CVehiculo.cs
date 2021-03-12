using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_6_4
{
    class CVehiculo
    {
        protected string marca;
        protected string modelo;
        protected int cilindrada;
        protected float potencia;
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
