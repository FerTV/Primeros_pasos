using System;

namespace Ejercicio_4_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            double media;

            Console.Write("Introduce el número 1: ");
            array[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el número 2: ");
            array[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el número 3: ");
            array[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el número 4: ");
            array[3] = Convert.ToInt32(Console.ReadLine());

            media = (array[0]+array[1]+array[2]+array[3]) / 4.0;

            Console.WriteLine("La media de los números {0}, {1}, {2} y {3} es: {4}.", array[0], array[1], array[2], array[3], media);
        }
    }
}
