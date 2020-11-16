using System;

namespace Ejercicio_4_4_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string subcadena;
            int j = 0;

            Console.Write("Introduce el nombre: ");
            nombre = Console.ReadLine();

            for (int i = 0; i < nombre.Length; i++)
            {
                subcadena = nombre.Substring(i, i+1);
                Console.Write("{0}", subcadena);
            }
        }
    }
}
