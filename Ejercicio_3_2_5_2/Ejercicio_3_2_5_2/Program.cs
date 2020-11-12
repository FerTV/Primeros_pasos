using System;

namespace Ejercicio_3_2_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0, z = 0, resultado = 0;

            Console.Write("Introduce x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce z: ");
            z = Convert.ToDouble(Console.ReadLine());

            resultado = (Math.Pow(x, 2)) + y - z;
            Console.Write("El resultado es ");
            Console.WriteLine(resultado.ToString("N3"));
        }
    }
}
