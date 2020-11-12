using System;

namespace Ejercicio_2_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, division=0;

            Console.Write("Introduce un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n2 != 0)
            {
                division = n1 / n2;
                Console.WriteLine("La división de {0} entre {1} es: {2}", n1, n2, division);
            }
            else
                Console.WriteLine("Error:No se puede dividir entre cero.");
        }
    }
}
