using System;

namespace Ejercicio_2_5_1_8
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

            if (n1 >= 0 && n2 >= 0)
                Console.WriteLine("Los dos números son positivos.");
            else if ((n1 >= 0 && n2 < 0) || (n2 >= 0 && n1 < 0))
                Console.WriteLine("Uno de los dos números es positivo.");
            else
                Console.WriteLine("Ninguno de los dos números es positivo.");
        }
    }
}
