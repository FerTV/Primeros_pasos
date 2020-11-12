using System;

namespace Ejercicio_3_2_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, resultado = 0;


            Console.Write("Introduce el primer número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            resultado = n1 / n2;
            Console.Write("El resultado es ");
            Console.WriteLine(resultado.ToString("N3"));

        }
    }
}
