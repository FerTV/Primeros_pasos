using System;

namespace Ejercicio_2_1_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, n3 = 0;

            Console.Write("Introduce el primer número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el tercer número: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
                Console.WriteLine("El primer número es el mayor de los 3.");
            else if (n2 > n1 && n2 > n3)
                Console.WriteLine("El segundo número es el mayor de los 3.");
            else
                Console.WriteLine("El tercer número es el mayor de los 3.");
        }
    }
}
