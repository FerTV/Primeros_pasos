using System;

namespace Ejercicio_2_6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura = 0;

            Console.Write("Introduce la altura del triángulo: ");
            altura = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<altura;i++)
            {
                for(int j=altura;j>=0;j--)
                {
                    if (j > i)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
