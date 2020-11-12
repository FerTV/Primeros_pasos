using System;

namespace Ejercicio_2_2_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i >= 10; i--)
            {
                if (i == 13)
                    continue;

                Console.Write("{0} ", i);
            }
        }
    }
}
