using System;

namespace Ejercicio_3_2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rojo = 0, azul = 0, verde = 0;

            Console.Write("Introduce la cantidad de rojo: ");
            rojo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce la cantidad de verde: ");
            verde = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce la cantidad de azul: ");
            azul = Convert.ToInt32(Console.ReadLine());

            Console.Write("El RGB en notación hexadecimal es: ");
            Console.Write(Convert.ToString(rojo, 16));
            Console.Write(Convert.ToString(verde, 16));
            Console.WriteLine(Convert.ToString(azul, 16));
        }
    }
}
