using System;

namespace Ejercicio_2_2_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 106; i += 2)
            {
                if (i % 10 == 0)
                    continue;

                Console.Write("{0} ", i);
            }
        }
    }
}
