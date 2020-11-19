using System;

namespace Ejercicio_4_4_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string subcadena;
            int i = 1;

            Console.Write("Introduce el nombre: ");
            nombre = Console.ReadLine();

            for (int j = 0; i <= nombre.Length; j++)
            {
                subcadena = nombre.Substring(i, j);
                Console.Write("{0} ", subcadena);
                i++;
            }
        }
    }
}
