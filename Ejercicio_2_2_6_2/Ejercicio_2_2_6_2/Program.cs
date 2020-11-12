using System;

namespace Ejercicio_2_2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho = 0, alto = 0;

            Console.Write("Introduce el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el alto: ");
            alto = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
