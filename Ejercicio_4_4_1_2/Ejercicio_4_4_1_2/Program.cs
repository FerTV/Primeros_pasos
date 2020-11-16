using System;

namespace Ejercicio_4_4_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Introduce tu nombre: ");
            nombre = Console.ReadLine();

            if (nombre == "fer")
                Console.WriteLine("Bienvenido Jefe.");
            else
                Console.WriteLine("Bienvenido {0}", nombre);
        }
    }
}
