using System;

namespace Ejercicio_3_2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 13, i2 = 6, resultadoi = 0;
            float f1 = 13, f2 = 6, resultadof = 0;
            double d1 = 13, d2 = 6, resultadod = 0;

            resultadoi = i1 / i2;
            resultadof = f1 / f2;
            resultadod = d1 / d2;

            Console.WriteLine("El resultado de 13/6 en int es {0}, en float es {1} y en double es {2}.", resultadoi, resultadof, resultadod);
        }
    }
}
