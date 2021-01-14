using System;

namespace Ejercicio_5_9_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = new double[73];

            for (int i = 0; i < 73; i++)
            {
                valores[i] = 10 * Math.Sin(5 * i * (Math.PI / 180));
            }
            for (int i = 0; i < 73; i++)
            {
                Console.WriteLine("Valor de la función para {0} grados: {1}", i, valores[i]);
            }
        }
    }
}
