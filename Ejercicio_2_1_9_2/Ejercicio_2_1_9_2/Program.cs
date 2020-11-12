using System;
using System.Diagnostics;

namespace Ejercicio_2_1_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char c ='0';

            Console.Write("Introduce una letra: ");
            c = Convert.ToChar(Console.Read());

            switch (c)
            {
                case '.':
                    Console.WriteLine("Se trata de un signo de puntuación.");
                    break;
                case ',':
                    Console.WriteLine("Se trata de un signo de puntuación.");
                    break;
                case ';':
                    Console.WriteLine("Se trata de un signo de puntuación.");
                    break;
                case ':':
                    Console.WriteLine("Se trata de un signo de puntuación.");
                    break;
                case '0':
                    Console.WriteLine("Se trata de un número.");
                    break;
                case '1':
                    Console.WriteLine("Se trata de un número.");
                    break;
                case '2':
                    Console.WriteLine("Se trata de un número.");
                    break;
                case '3':
                    Console.WriteLine("Se trata de un número.");
                    break;
                case '4':
                    Console.WriteLine("Se trata de un número.");
                    break;
                case '5':
                    Console.WriteLine("Se trata de un número.");
                    break;
                case '6':
                    Console.WriteLine("Se trata de un número.");
                    break;
                case '7':
                    Console.WriteLine("Se trata de un número.");
                    break;
                case '8':
                    Console.WriteLine("Se trata de un número.");
                    break;
                case '9':
                    Console.WriteLine("Se trata de un número.");
                    break;
                default:
                    Console.WriteLine("Se trata de otro tipo de cáracter que no es ni signo de puntuación ni un número.");
                    break;
            }
        }
    }
}
