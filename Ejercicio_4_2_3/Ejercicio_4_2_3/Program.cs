using System;

namespace Ejercicio_4_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros;
            int tam1, tam2;
            int mayor = 0;

            Console.Write("Introduce el tamaño del primer bloque de números: ");
            tam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el tamaño del segundo bloque de números: ");
            tam2 = Convert.ToInt32(Console.ReadLine());

            numeros = new int[tam1,tam2];

            for (int i = 0; i < tam1; i++)
            {
                Console.WriteLine("Introduce los datos del bloque {0}:", i + 1);
                for (int j = 0; j < tam2; j++)
                {
                    Console.Write("Introduce el dato {0}", j + 1);
                    numeros[i, j] = Convert.ToInt32(Console.ReadLine());

                    if (numeros[i, j] > mayor)
                        mayor = numeros[i, j];
                }
                Console.WriteLine("El número mayor del bloque {0} es: {1}", i + 1, mayor);
            }
        }
    }
}
