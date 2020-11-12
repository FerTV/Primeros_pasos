using System;

namespace Ejercicio_2_2_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, mayor= 0;

            Console.Write("Introduce un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 < n2)
            {
                mayor = n1;
            }
            else
            {
                mayor = n2;
            }

            for (int i = mayor; i >= mayor; i++)
            {
                if (i % n1 == 0 && i % n2 == 0)
                {
                    Console.WriteLine("Su mínimo común múltiplo es: {0}", i);
                    break;
                }
            }
        }
    }
}
