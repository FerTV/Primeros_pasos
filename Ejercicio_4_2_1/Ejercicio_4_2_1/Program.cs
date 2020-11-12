using System;

namespace Ejercicio_4_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros=new int[2,10];
            int mayor = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("Introduce un número: ");
                    numeros[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (numeros[i, j] > mayor)
                        mayor = numeros[i, j];
                }
                Console.WriteLine("El número mayor del vector {0} es: {1}", i+1, mayor);
            }
        }
    }
}
