using System;

namespace Ejercicio_2_2_1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 1, numero2 = 1;

            while (numero1 != 0 && numero2 != 0)
            {
                Console.Write("Introduce un número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce otro número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                if ((numero1 != 0 && numero2 != 0) && (numero1 % numero2 == 0))
                {
                    Console.WriteLine("El primer número es múltiplo del segundo.");
                }
            }
        }
    }
}
