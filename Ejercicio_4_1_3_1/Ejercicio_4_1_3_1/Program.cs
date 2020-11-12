using System;

namespace Ejercicio_4_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];

            Console.Write("Introduce el número 1: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el número 2: ");
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el número 3: ");
            numeros[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el número 4: ");
            numeros[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el número 5: ");
            numeros[4] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el número 6: ");
            numeros[5] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Los números introducidos en orden inverso son: ");
            for(int i=5;i>=0;i--)
            {
                Console.Write("{0} ", numeros[i]);
            }
        }
    }
}
