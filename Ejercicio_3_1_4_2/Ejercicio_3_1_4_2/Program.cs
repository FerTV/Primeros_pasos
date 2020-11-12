using System;

namespace Ejercicio_3_1_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //a=20, b=4, c=-5;
            int a = 0, b = 0, c = 0;

            a = 5;
            b = a + 2;
            b -= 3;
            c = -3;
            c *= 2;
            ++c;
            a *= b;

            Console.WriteLine("El resultado de a, b, c es: {0}, {1}, {2}.", a, b, c);
        }
    }
}
