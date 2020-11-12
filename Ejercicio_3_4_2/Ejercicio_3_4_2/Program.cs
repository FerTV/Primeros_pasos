using System;

namespace Ejercicio_3_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, contra1, contra2;

            Console.Write("Introduce tu nombre de usuario: ");
            nombre = Convert.ToString(Console.ReadLine());

            do
            {
                Console.Write("Introduce tu contraseña: ");
                contra1 = Convert.ToString(Console.ReadLine());
                Console.Write("Vuelve a introducir la contraseña: ");
                contra2 = Convert.ToString(Console.ReadLine());

                if (contra1 != contra2)
                    Console.WriteLine("La contraseña no coincide {0}", nombre);
            } while (contra1!=contra2);
            Console.WriteLine("Has iniciado sesión correctamente {0}", nombre);
        }
    }
}
