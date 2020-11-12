using System;

namespace Ejercicio_2_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 10 == 0)
            {
                Console.WriteLine("El número es múltiplo de 10");
                Console.Write("Introduce un número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 10 == 0)
                {
                    Console.WriteLine("El número es múltiplo de 10");
                }
            }
        }
    }
}
