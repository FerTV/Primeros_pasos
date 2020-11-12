using System;

namespace Ejercicio_3_2_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b=0, c=0, raiz=0, solucion1=0, solucion2=0;

            Console.WriteLine("Dada una ecuación y= Ax^2 + Bx + C. ");

            Console.Write("Introduce A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce C: ");
            c = Convert.ToInt32(Console.ReadLine());

            raiz = Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c));

            solucion1 = ((-b + raiz) / (2 * a));
            solucion2 = ((-b - raiz) / (2 * a));

            Console.WriteLine("La primera solución de la ecuacion es {0}, la segunda solución es {1}.", solucion1, solucion2);
        }
    }
}
