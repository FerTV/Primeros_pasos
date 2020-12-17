using System;

namespace Ejercicio_5_2_2
{
    class Program
    {
        public static void DibujarCuadrado3x3()
        {
            DibujarCuadrado(3, 3);
        }

        public static void DibujarCuadrado(int filas, int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int filas, columnas;

            Console.WriteLine("Dibujo cuadrado 3x3: ");
            DibujarCuadrado3x3();
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-------------------Dibujo cuadrado de cualquier tamaño------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");
            Console.Write("Introduce las filas: ");
            filas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce las columnas: ");
            columnas = Convert.ToInt32(Console.ReadLine());
            DibujarCuadrado(filas, columnas);
        }
    }
}
