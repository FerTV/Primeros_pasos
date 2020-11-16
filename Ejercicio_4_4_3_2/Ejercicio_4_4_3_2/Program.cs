using System;

namespace Ejercicio_4_4_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;

            Console.Write("Introduce una frase: ");
            frase = Console.ReadLine();

            for (int i = frase.Length-1; i >= 0; i--)
            {
                Console.Write(frase[i]);
            }
        }
    }
}
