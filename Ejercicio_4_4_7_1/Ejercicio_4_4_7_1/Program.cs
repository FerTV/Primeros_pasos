using System;

namespace Ejercicio_4_4_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            char delimitador = ' ';

            Console.Write("Introduce una frase: ");
            frase = Console.ReadLine();

            string[] fragmentos = frase.Split(delimitador);

            Console.WriteLine("\nLa frase en orden inverso es: ");
            for (int i = fragmentos.Length-1; i >= 0; i--)
            {
                Console.Write("{0} ", fragmentos[i]);
            }
        }
    }
}
