using System;

namespace Ejercicio_2_2_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 20; i++)
            {
                Console.WriteLine("El número {0} es divisible entre: ",i);

                for (int j = 5; j <= 7; j++)
                {
                    if (i % j == 0)
                        Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
