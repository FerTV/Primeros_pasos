using System;

namespace Ejercicio_2_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int tam = 0;

            do
            {
                Console.Write("Introduce el tamaño del cuadrado: ");
                tam = Convert.ToInt32(Console.ReadLine());

                if (tam > 9)
                    Console.WriteLine("ERROR. El tamaño introducido es mayor que 9.");
            } while (tam > 9);

            for (int i = 1; i <= tam; i++)
            {
                for(int j=1;j<=tam;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
