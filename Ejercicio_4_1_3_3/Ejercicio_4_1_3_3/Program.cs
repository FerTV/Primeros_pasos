using System;

namespace Ejercicio_4_1_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[10];
            double media=0;
            
            for(int i=0;i<10;i++)
            {
                Console.Write("Introduce el número {0}: ", i+1);
                numeros[i] = Convert.ToDouble(Console.ReadLine());
                media += numeros[i];
            }
            media = media / 10;

            Console.Write("Los números: ");
            for(int j=0;j<10;j++)
            {
                if (numeros[j] > media)
                    Console.Write("{0} ", numeros[j]);
            }
            Console.WriteLine("estan por encima de la media.");
        }
    }
}
