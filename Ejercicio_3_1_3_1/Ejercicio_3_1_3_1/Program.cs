using System;

namespace Ejercicio_3_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si usas int la z se desborda.
            long x = 15, y = -10, z = 2147483647;

            Console.Write("Los valores de x, y, z una vez incrementados son: ");

            x++;
            y++;
            z++;

            Console.WriteLine("{0}, {1}, {2}.", x, y, z);
        }
    }
}
