using System;

namespace Ejercicio_2_2_8_2
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

            for (int columnaActual = 0; columnaActual < alto; columnaActual++)
            {
                for (int filaActual = 0; filaActual < ancho; filaActual++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
