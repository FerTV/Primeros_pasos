using System;

namespace Ejercicio_3_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condicion;
            int n1, n2;

            Console.Write("Introduce un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            condicion = n1 == n2 ? true : false;

            Console.WriteLine("Los números que has tecleado son iguales? {0}", condicion);
        }
    }
}
