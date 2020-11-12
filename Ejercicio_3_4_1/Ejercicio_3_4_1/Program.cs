using System;

namespace Ejercicio_3_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Introduce un nombre: ");
            nombre = Convert.ToString(Console.ReadLine());

            if (nombre == "Juan")
                Console.WriteLine("Hola");
            else
                Console.WriteLine("No te conozco");
        }
    }
}
