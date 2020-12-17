using System;

namespace Ejercicio_5_2_2
{
    class Program
    {
        public static void DibujarCuadrado3x3()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dibujo cuadrado 3x3: ");
            DibujarCuadrado3x3();
        }
    }
}
