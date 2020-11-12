using System;
using System.Globalization;

namespace Ejercicio_4_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] cadenas = new string[2, 6];
            string cadena_buscar;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Introduce la cadena de texto {0}: ", i);
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("Introduce la cadena {0}: ", j`+1);
                    cadenas[i, j] = Convert.ToString(Console.ReadLine());
                }
            }

            Console.Write("Introduce una cadena: ");
            cadena_buscar = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (cadenas[i, j] == cadena_buscar)
                    {
                        Console.WriteLine("La cadena se encuentra en el vector {0} posición {1}", i+1, j+1);
                        break;
                    }
                }
            }
        }
    }
}
