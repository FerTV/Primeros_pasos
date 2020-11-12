using System;

namespace Ejercicio_2_1_9_6
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = '0';

            Console.Write("Introduce un cáracter: ");
            c = Convert.ToChar(Console.Read());

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                Console.WriteLine("El cáracter introducido es una vocal.");
            else if (c >= '0' && c <= '9')
                Console.WriteLine("El cáracter introducido es un número.");
            else if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
                Console.WriteLine("El cáracter introducido es una consonante.");
        }
    }
}
