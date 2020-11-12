using System;

namespace Ejercicio_3_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool par_impar;
            int n1, n2;

            Console.Write("Introduce un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            par_impar = (n1 % 2 == 0) && (n2 % 2 == 0) ? true : false;

            Console.WriteLine("Ambos números son pares? {0}", par_impar);
        }
    }
}
