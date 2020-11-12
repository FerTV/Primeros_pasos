using System;

namespace Ejercicio_2_1_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0;

            Console.Write("Escribe un número: ");
            a = Convert.ToInt32(Console.ReadLine());

            b = a > 0 ? a : -a;

            Console.WriteLine("El valor absoluto de {0} es {1}.", a, b);
        }
    }
}
