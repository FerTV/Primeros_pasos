using System;

namespace Ejercicio_5_10_3
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            if (n == 1 || n == 0)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
