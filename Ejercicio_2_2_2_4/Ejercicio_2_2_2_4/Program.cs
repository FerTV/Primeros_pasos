using System;

namespace Ejercicio_2_2_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int identificador = 0, contrasena = 0;

            do
            {

                Console.Write("Introduce tu identificador: ");
                identificador = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduce tu contraseña: ");
                contrasena = Convert.ToInt32(Console.ReadLine());

            } while (identificador != 1234 || contrasena != 1111);

            Console.WriteLine("Sesión iniciada correctamente.");
        }
    }
}
