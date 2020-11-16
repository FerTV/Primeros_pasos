using System;

namespace Ejercicio_4_4_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int j = 0;

            Console.Write("Introduce tu nombre: ");
            nombre = Console.ReadLine();

            for (int i = 0; j < nombre.Length; i++)
            {
                if (i % 2 != 0)
                    Console.Write(" ");
                else
                {
                    Console.Write(nombre[j]);
                    j++;
                }
            }
        }
    }
}
