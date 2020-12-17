using System;

namespace Ejercicio_5_2_1
{
    class Program
    {
        static void BorrarPantalla()
        {
            /*for (int i = 0; i < 25; i++)
                Console.WriteLine();
            */
            Console.Clear();//Borra la pantalla
        }
        static void Main(string[] args)
        {
            string cadena;

            Console.Write("Introduce un texto: ");
            cadena = Console.ReadLine();

            Console.WriteLine("\nTu cadena repetida 10 veces: ");
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(cadena);
            }

            BorrarPantalla();
        }
    }
}
