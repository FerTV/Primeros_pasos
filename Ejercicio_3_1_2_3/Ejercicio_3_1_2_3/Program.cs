using System;

namespace Ejercicio_3_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long n1 = 0, n2 = 0, suma = 0, resta = 0, producto = 0;

            Console.Write("Introduce un número: ");
            n1 = Convert.ToInt64(Console.ReadLine());

            Console.Write("Introduce otro número: ");
            n2 = Convert.ToInt64(Console.ReadLine());

            suma = n1 + n2;
            resta = n1 - n2;
            producto = n1 * n2;

            Console.WriteLine("La suma de {0} más {1} es: {2}. La resta de {0} menos {1} es: {3}. El producto de {0} por {1} es: {4}.", n1, n2, suma, resta, producto);
        }
    }
}
