using System;

namespace Ejercicio_2_1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;

            Console.Write("Introduce el primer número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 % n2 == 0)
                Console.WriteLine("El primer número es múltiplo del segundo.");
            else
                Console.WriteLine("El primer número no es múltiplo del segundo.");
        }
    }
}
