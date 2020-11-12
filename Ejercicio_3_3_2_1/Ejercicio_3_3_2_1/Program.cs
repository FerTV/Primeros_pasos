using System;

namespace Ejercicio_3_3_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char l0, l1, l2, l3;

            Console.Write("Introduce la primera letra: ");
            l0 = Convert.ToChar(Console.ReadLine());
            Console.Write("Introduce la segunda letra: ");
            l1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Introduce la tercera letra: ");
            l2 = Convert.ToChar(Console.ReadLine());
            Console.Write("Introduce la cuarta letra: ");
            l3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\"{0}{1}{2}{3}\"", l3, l2, l1, l0);
        }
    }
}
