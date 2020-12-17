using System;

namespace Ejercicio_5_3_2
{
    class Program
    {
        public static void DibujarRectangulo(int ancho, int alto)
        {
            for(int i=0; i<alto;i++)
            {
                for (int j = 0; j < ancho; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int ancho, alto;

            Console.Write("Introduce el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el alto: ");
            alto = Convert.ToInt32(Console.ReadLine());
            DibujarRectangulo(ancho, alto);
        }
    }
}
