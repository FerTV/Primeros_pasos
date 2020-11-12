using System;

namespace Ejercicio_3_2_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_terminos = 0;
            double pi = 0, denominador=1;

            Console.Write("Introduce el número de términos a utilizar: ");
            num_terminos = Convert.ToInt32(Console.ReadLine());

            Console.Write("pi/4= ");
            /*
            int j = 1;
            for (int i = 1; j <= num_terminos; i += 2)
            {
                if (j == 1)
                {
                    pi = 1;
                    Console.Write("1/1 ");
                }
                else if (j % 2 == 0)
                {
                    pi -= (double)1 / i;
                    Console.Write(" - 1/{0} ", i);
                }
                else
                {
                    pi += (double)1 / i;
                    Console.Write(" + 1/{0} ", i);
                }
                j++;
            }
            Console.WriteLine("= {0}.", pi);
            */
            for(int i=1;i<=num_terminos;i++)
            {
                if (i == 1)
                {
                    pi = 1;
                    Console.Write("1/1 ");
                    denominador += 2;
                }
                else if (i % 2 == 0)
                {
                    pi -= 1 / denominador;
                    Console.Write("- 1/{0} ", denominador);
                    denominador += 2;
                }
                else
                {
                    pi += 1 / denominador;
                    Console.Write("+ 1/{0} ", denominador);
                    denominador += 2;
                }
            }
            Console.WriteLine("= {0}.", pi);
        }
    }
}
