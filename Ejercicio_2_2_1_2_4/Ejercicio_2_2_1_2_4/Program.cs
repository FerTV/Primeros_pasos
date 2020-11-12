using System;

namespace Ejercicio_2_2_1_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int random = new Random().Next(0, 10), numero = 0, i = 2;

            while (numero != random && i >= 0)
            {
                Console.Write("Introduce un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == random)
                    Console.WriteLine("Has adivinado el número.");

                i--;
            }
        }
    }
}
