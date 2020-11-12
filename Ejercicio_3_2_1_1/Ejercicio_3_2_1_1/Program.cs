using System;

namespace Ejercicio_3_2_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 3, i2 = 4, resultado_int=0;
            float f1 = 3, f2 = 4, resultado_float=0;

            resultado_int = i1 / i2;
            resultado_float = f1 / f2;

            Console.WriteLine("El resultado de dividir 3/4 con int es: {0}, mientras que con float es: {1}.", resultado_int, resultado_float);
        }
    }
}
