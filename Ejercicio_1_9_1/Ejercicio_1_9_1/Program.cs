using System;

namespace Ejercicio_1_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=0;

            Console.Write("Escribe el número 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escribe el número 2: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("El producto de los números introducidos es: "+ a*b);
        }
    }
}
