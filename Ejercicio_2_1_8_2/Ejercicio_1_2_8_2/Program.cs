using System;

namespace Ejercicio_2_1_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, menor=0;

            Console.Write("Introduce un número: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            b = Convert.ToInt32(Console.ReadLine());

            menor = a < b ? a : b;

            Console.WriteLine("El número {0} es el menor de los dos", menor);
        }
    }
}
