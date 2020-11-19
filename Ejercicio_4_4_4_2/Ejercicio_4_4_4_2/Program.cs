using System;

namespace Ejercicio_4_4_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string subcadena;

            Console.Write("Introduce tu nombre: ");
            nombre = Console.ReadLine();

            for(int j=1;j<=nombre.Length;j++)
            {
                subcadena = nombre.Substring(0, j);
                Console.Write("{0}\n", subcadena);
            }
        }
    }
}
