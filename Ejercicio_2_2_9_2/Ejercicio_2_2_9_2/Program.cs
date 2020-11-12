using System;

namespace Ejercicio_2_2_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, mayor=0;

            Console.Write("Escribe un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if(n1>n2)
            {
                mayor = n1;
            }
            else
            {
                mayor = n2;
            }

            Console.Write("Los divisores comunes de ambos números son: ");

            for (int i = 1; i < mayor; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
