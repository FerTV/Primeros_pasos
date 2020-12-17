using System;

namespace Ejercicio_5_4_3
{
    class Program
    {
        public static int Signo(int x)
        {
            if (x < 0)
                return -1;
            else if (x == 0)
                return 0;
            else
                return 1;
        }
        static void Main(string[] args)
        {
            int n, signo;

            Console.Write("Introduce un número: ");
            n = Convert.ToInt32(Console.ReadLine());
            switch (Signo(n))
            {
                case -1:
                    Console.WriteLine("El número es negativo");
                    break;
                case 0:
                    Console.WriteLine("El número es el 0");
                    break;
                default:
                    Console.WriteLine("El número es positivo");
                    break;
            }
        }
    }
}
