using System;

namespace Ejercicio_5_9_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] pantalla = new int[24,79];
            Random r = new Random();
            int alto_random, ancho_random;

            for(int i=0;i<100;i++)
            {
                alto_random = r.Next(0, 24);
                ancho_random = r.Next(0, 79);
                pantalla[alto_random, ancho_random] = '*';
            }

            for(int i=0;i<24;i++)
            {
                for(int j=0;j<79;j++)
                {
                    if (pantalla[i, j] == '*')
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
