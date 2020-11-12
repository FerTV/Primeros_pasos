using System;

namespace Ejercicio_4_1_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vector = new double[3];
            double modulo = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Introduce la componente {0} del vector: ", i + 1);
                vector[i] = Convert.ToDouble(Console.ReadLine());
            }

            for(int i=0;i<3;i++)
            {
                modulo += Math.Pow(vector[i], 2);
            }

            modulo = Math.Sqrt(modulo);

            //modulo = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2));

            Console.WriteLine("El módulo del vector es: {0}.", modulo);
        }
    }
}
