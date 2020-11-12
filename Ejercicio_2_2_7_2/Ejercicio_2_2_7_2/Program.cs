using System;

namespace Ejercicio_2_2_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (char letra = 'L'; letra <= 'N'; letra++)
                {
                    Console.Write(letra);
                }
                Console.Write(" ");
            }
        }
    }
}
