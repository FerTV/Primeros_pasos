using System;

namespace Ejercicio_4_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
                int[,] matriz = new int[3, 3];
                int determinante;

           for (int i = 0; i < 3; i++)
           {
                Console.Write("De la fila {0} ", i + 1);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("introduce la componente {0}: ", j + 1);
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
           }

            determinante = matriz[0, 0] * matriz[1, 1] * matriz[2, 2] + (matriz[0, 1] * matriz[1, 2] * matriz[2, 0]) + (matriz[1, 0] * matriz[2, 1] * matriz[0, 2]) - ((matriz[0, 2] * matriz[1, 1] * matriz[2, 0]) + (matriz[0, 1] * matriz[1, 0] * matriz[2, 2]) + (matriz[1, 2] * matriz[2, 1] * matriz[0, 0]));

            if (determinante == 0)
                Console.WriteLine("Los vectores son linealmente dependientes");
            else
                Console.WriteLine("Los vectores son linealmente independientes");
            
        }
    }
}
