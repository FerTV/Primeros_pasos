using System;

namespace Ejercicio_5_10_3
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            if (n == 1 || n == 0)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            int n=0, pos;

            Console.Write("Introduce el nº de Fibonacci a calcular: ");
            pos = Convert.ToInt32(Console.ReadLine());

            n = Fibonacci(pos);

            Console.WriteLine("EL número de Fibonacci de la posicion {0} es: {1}", pos, n);
        }
    }
}
