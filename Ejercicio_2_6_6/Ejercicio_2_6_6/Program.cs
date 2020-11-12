using System;

namespace Ejercicio_2_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int anchura = 0, altura = 0;

            Console.Write("Introduce la anchura: ");
            anchura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la altura: ");
            altura = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < anchura; j++)
                {
                    if (i == 0 || i == (altura - 1))
                        Console.Write("*");
                    else if (j == 0 || j == (anchura - 1))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
