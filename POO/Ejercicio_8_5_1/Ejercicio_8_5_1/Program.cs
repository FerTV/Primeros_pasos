using System;
using System.IO;

namespace Ejercicio_8_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
             using(StreamWriter fichero = new StreamWriter(".\\resultados\\sumas.txt", true))
             {
                int n1, n2, suma;

                Console.Write("Introduce el n1: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce el n2: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                suma = n1 + n2;
                Console.WriteLine("{0} + {1} = {2}", n1, n2, suma);
                fichero.WriteLine("{0} + {1} = {2}", n1, n2, suma);
             }
        }
    }
}
