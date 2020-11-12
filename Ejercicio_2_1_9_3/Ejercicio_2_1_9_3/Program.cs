using System;
using System.Diagnostics;

namespace Ejercicio_2_1_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = '0';

            Console.Write("Introduce un cáracter: ");
            c = Convert.ToChar(Console.Read());

            switch (c)
            {
                case 'a':
                    Console.WriteLine("Se trata de una vocal.");
                    break;
                case 'e':
                    Console.WriteLine("Se trata de una vocal.");
                    break;
                case 'i':
                    Console.WriteLine("Se trata de una vocal.");
                    break;
                case 'o':
                    Console.WriteLine("Se trata de una vocal.");
                    break;
                case 'u':
                    Console.WriteLine("Se trata de una vocal.");
                    break;
                case '0':
                    Console.WriteLine("Se trata de una cifra númerica.");
                    break;
                case '1':
                    Console.WriteLine("Se trata de una cifra númerica.");
                    break;
                case '2':
                    Console.WriteLine("Se trata de una cifra númerica.");
                    break;
                case '3':
                    Console.WriteLine("Se trata de una cifra númerica.");
                    break;
                case '4':
                    Console.WriteLine("Se trata de una cifra númerica.");
                    break;
                case '5':
                    Console.WriteLine("Se trata de una cifra númerica.");
                    break;
                case '6':
                    Console.WriteLine("Se trata de una cifra númerica.");
                    break;
                case '7':
                    Console.WriteLine("Se trata de una cifra númerica.");
                    break;
                case '8':
                    Console.WriteLine("Se trata de una cifra númerica.");
                    break;
                case '9':
                    Console.WriteLine("Se trata de una cifra númerica.");
                    break;
                default:
                    Console.WriteLine("Se trata de una consonante.");
                    break;
            }
        }
    }
}
