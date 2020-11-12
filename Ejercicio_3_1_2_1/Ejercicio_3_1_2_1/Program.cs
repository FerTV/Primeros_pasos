using System;

namespace Ejercicio_3_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte edad = 0;

            Console.Write("Introduce tu edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("No aparentas {0} años.", edad);
        }
    }
}
