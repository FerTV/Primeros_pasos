using System;

namespace Ejercicio_3_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long producto = 1000000;
            int producto1 = 1000000;

            producto = producto * 1000000;
            producto1 = producto1 * 1000000;

            Console.WriteLine("Resultado con long: {0}, resultado con int: {1}", producto , producto1);
        }
    }
}
