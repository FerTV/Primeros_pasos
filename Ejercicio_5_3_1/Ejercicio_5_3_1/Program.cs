using System;

namespace Ejercicio_5_3_1
{
    class Program
    {
        public static void DibujarCuadrado(int longitud)
        {
            for (int i = 0; i < longitud; i++)
            {
                for (int j = 0; j < longitud; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int longitud;

            Console.Write("Introduce la longitud: ");
            longitud = Convert.ToInt32(Console.ReadLine());
            DibujarCuadrado(longitud);
        }
    }
}
