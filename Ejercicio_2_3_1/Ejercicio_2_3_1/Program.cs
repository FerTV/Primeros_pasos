using System;

namespace Ejercicio_2_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            p1:

            if(n<=10)
            {
                Console.Write("{0} ", n);
                n++;
                goto p1;
            }
        }
    }
}
