using System;

namespace Ejercicio_2_1_9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            char c='0';

            Console.Write("Introduce un cáracter: ");
            c = Convert.ToChar(Console.Read());

            if ((c == ',') || (c == '.') || (c == ';') || (c == ':'))
                Console.WriteLine("El cáracter introducido es un signo de puntuación.");
            else if (c >= '0' && c <= '9')
                Console.WriteLine("El cáracter es una cifra númerica.");
            else
                Console.WriteLine("El cáracter introducido no es un signo de puntuación ni una cifra númerica.");
        }
    }
}
