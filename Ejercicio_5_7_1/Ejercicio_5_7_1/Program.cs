using System;

namespace Ejercicio_5_7_1
{
    class Program
    {
        public static void Intercambiar(ref int n1, ref int n2)
        {
            int temporal=n1;

            n1 = n2;
            n2 = temporal;
        }
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Introduce el número n1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el número n2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Intercambiar(ref n1, ref n2);
            Console.WriteLine("Ahora n1 es {0}, y n2 es {1}", n1, n2);
        }
    }
}
