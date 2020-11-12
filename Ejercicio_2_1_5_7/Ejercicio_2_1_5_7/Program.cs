using System;

namespace Ejercicio_2_1_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;

            Console.Write("Introduce un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if ((n1 % 2 == 0 && n2 % 2 != 0) || (n1 % 2 != 0 && n2 % 2 == 0))
                Console.WriteLine("Un número y sólo uno es par.");
        }
    }
}
