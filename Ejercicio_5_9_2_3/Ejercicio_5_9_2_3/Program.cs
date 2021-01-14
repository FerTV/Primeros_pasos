using System;

namespace Ejercicio_5_9_2_3
{
    class Program
    {
        public static void CalcularRaicesSegundoGrado(int a, int b, int c, ref double x1, ref double x2)
        {
            double modulo;

            modulo = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));

            if (double.IsNaN(modulo) || a == 0)
            {
                x1 = 100000;
                x2 = 100000;
            }
            else
            {
                x1 = (-b + modulo) / (2 * a);
                x2 = (-b - modulo) / (2 * a);
            }
        }
        static void Main(string[] args)
        {
            int a, b, c;
            double x1=0, x2=0;

            Console.Write("Introduce a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce c: ");
            c = Convert.ToInt32(Console.ReadLine());

            CalcularRaicesSegundoGrado(a, b, c, ref x1, ref x2);

            Console.WriteLine("La solucion x1 es {0}, x2 es {1}", x1, x2);
        }
    }
}
