using System;

namespace Ejercicio_2_2_3_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=100;i<=200;i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
