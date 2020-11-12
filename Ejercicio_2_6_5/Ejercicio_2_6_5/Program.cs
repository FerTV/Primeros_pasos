using System;

namespace Ejercicio_2_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura = 0;

            Console.Write("Introduce la altura del triángulo: ");
            altura = Convert.ToInt32(Console.ReadLine());

            for (int i = altura; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
