using System;

namespace Ejercicio_2_2_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i >= 10; i -= 2)
            {
                if (i == 14)
                    continue;

                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            int j = 20;

            while (j >= 10)
            {
                /*
                if (j == 14)
                {
                    continue;
                }   NO SE PUEDE, SE CREA UN BUCLE INFINITO
                */
                if (j == 14)//otra opcion más optima sería if (j != 14) 
                { }
                else
                {
                    Console.Write("{0} ", j);
                }

                j -= 2;
            }
        }
    }
}
