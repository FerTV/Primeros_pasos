using System;

namespace Ejercicio_2_1_5_10
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

            if (n1 == n2)
                Console.WriteLine("Ambos números son iguales.");
            else if (n1 > n2)
                Console.WriteLine("El primer número es mayor que el segundo.");
            else
                Console.WriteLine("El segundo número es mayor que el primero.");
        }
    }
}
