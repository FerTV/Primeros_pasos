using System;

namespace Ejercicio_3_3_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.Write("Introduce una letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'||letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                Console.WriteLine("La letra es una vocal.");
            else
                Console.WriteLine("La letra no es una vocal.");
        }
    }
}
