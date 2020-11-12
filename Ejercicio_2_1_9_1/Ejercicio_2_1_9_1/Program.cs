using System;
using System.Diagnostics;

namespace Ejercicio_2_1_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.Write("Introduce un número comprendido entre el 1 y el 5: ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("El número introducido es el número uno");
                    break;
                case 2:
                    Console.WriteLine("El número introducido es el número dos");
                    break;
                case 3:
                    Console.WriteLine("El número introducido es el número tres");
                    break;
                case 4:
                    Console.WriteLine("El número introducido es el número cuatro");
                    break;
                case 5:
                    Console.WriteLine("El número introducido es el número cinco");
                    break;
                default:
                    Console.WriteLine("El número introducido no esta entre el 1 y el 5");
                    break;
            }
        }
    }
}
