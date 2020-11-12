using System;

namespace Ejercicio_4_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] array= new float[5];

            Console.Write("Introduce el número 1: ");
            array[0] = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduce el número 2: ");
            array[1] = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduce el número 3: ");
            array[2] = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduce el número 4: ");
            array[3] = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduce el número 5: ");
            array[4] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Los números introducidos desde el último hasta el primero son: {0}, {1}, {2}, {3}, {4}.", array[4], array[3], array[2], array[1], array[0]);
        }
    }
}
