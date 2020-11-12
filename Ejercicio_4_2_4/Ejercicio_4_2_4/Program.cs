using System;

namespace Ejercicio_4_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] componentes = new int[2, 2];
            int determinante;

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write("Introduce la componente {0} de la fila {1} de la matriz: ", j + 1, i + 1);
                    componentes[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            determinante = componentes[0, 0] * componentes[1, 1] - (componentes[0,1]*componentes[1,0]);

            Console.WriteLine("El determinante de la matriz es: {0}", determinante);
        }
    }
}
