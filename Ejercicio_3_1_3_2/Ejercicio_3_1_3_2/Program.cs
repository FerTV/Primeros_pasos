using System;

namespace Ejercicio_3_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //El resultado es a=14, b=30 y c=6.
            int a = 0, b = 0, c = 0;

            a = 5;
            b = ++a;
            c = a++;
            b = b * 5;
            a = a * 2;

            Console.WriteLine("Los valores de a, b y c son: {0}, {1}, {2}.", a, b, c);
        }
    }
}
