using System;

namespace Ejercicio_2_2_1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 26;

            while(i>=10)
            {
                if (i % 2 == 0)
                    Console.Write("{0} ",i);
                i--;
            }
        }
    }
}
