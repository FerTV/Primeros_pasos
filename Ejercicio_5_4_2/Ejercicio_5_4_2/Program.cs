using System;

namespace Ejercicio_5_4_2
{
    class Program
    {
        public static int CalcularMenor(int x, int y)
        {
            int menor;

            menor = x < y ? x : y;

            return menor;
        }
        static void Main(string[] args)
        {
            int n1, n2, menor;

            Console.Write("Introduce un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            menor = CalcularMenor(n1, n2);
            Console.Write("El menor de los dos números es: {0}", menor);
        }
    }
}
