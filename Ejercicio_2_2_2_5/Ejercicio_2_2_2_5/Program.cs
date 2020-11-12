using System;

namespace Ejercicio_2_2_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string identificador = "0", contrasena = "0";

            do
            {

                Console.Write("Introduce tu identificador: ");
                identificador = Console.ReadLine();

                Console.Write("Introduce tu contraseña: ");
                contrasena = Console.ReadLine();

            } while (identificador != "Pedro" || contrasena != "Peter");

            Console.WriteLine("Sesión iniciada correctamente.");
        }
    }
}
