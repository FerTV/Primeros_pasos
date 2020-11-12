using System;

namespace Ejercicio_2_1_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0 || numero % 3 == 0)
                Console.WriteLine("El número es múltiplo de 2 o de 3.");
        }
    }
}
