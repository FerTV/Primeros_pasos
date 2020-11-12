using System;

namespace Ejercicio_3_2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //9,5
            float a = 0;

            a = 5;
            a /= 2;
            a += 1;
            a *= 3;
            --a;

            Console.WriteLine("El resultado tras operar a es: {0}.", a);
        }
    }
}
