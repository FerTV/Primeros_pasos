using System;

namespace Ejercicio_2_2_12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 200; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            int j = 100;

            while(j<=200)
            {
                Console.Write("{0} ", j);

                j++;
            }
        }
    }
}
