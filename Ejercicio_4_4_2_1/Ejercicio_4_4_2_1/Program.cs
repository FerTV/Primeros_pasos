using System;

namespace Ejercicio_4_4_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Introduce tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("La inicial de tu nombre es {0}", nombre[0]);
        }
    }
}
