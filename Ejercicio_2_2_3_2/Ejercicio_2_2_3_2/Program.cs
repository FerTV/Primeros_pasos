using System;

namespace Ejercicio_2_2_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if (i % 3 == 0)
                    Console.Write("{0} ", i);
            }
        }
    }
}
