using System;

namespace Ejercicio_2_2_1_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 1, numero2 = 1;

            while (numero2 != 0)
            {
                Console.Write("Introduce un número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce otro número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                if (numero2 != 0)
                {
                    if ((numero1 % numero2 == 0))
                    {
                        Console.WriteLine("El primer número es múltiplo del segundo.");
                    }
                    else if(numero2 % numero1 ==0)
                    {
                        Console.WriteLine("El segundo número es múltiplo del primero.");
                    }
                    else
                    {
                        Console.WriteLine("Niguno de ellos es múltiplo del otro.");
                    }
                }
            }
        }
    }
}
