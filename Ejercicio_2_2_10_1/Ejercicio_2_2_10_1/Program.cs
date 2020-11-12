using System;

namespace Ejercicio_2_2_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, menor=0;

            Console.Write("Introduce un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if(n1<n2)
            {
                menor = n1;
            }
            else
            {
                menor = n2;
            }

            for (int i = menor; i >= 1; i--)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    Console.WriteLine("Su máximo común divisor es: {0}", i);
                    break;
                }
            }
        }
    }
}
