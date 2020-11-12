using System;

namespace Ejercicio_2_2_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1, i=0;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while(numero!=0)
            {
                numero = numero / 10;
                i++;
            }

            Console.WriteLine("El numero introducido tiene {0} cifras.", i);
        }
    }
}
