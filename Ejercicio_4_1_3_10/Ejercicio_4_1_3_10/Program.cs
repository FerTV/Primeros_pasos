using System;

namespace Ejercicio_4_1_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[3];
            int[] vector2 = new int[3];
            int producto_escalar=0;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Introduce el vector {0}", i + 1);

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" componente {0}: ", j + 1);

                    if (i == 0)
                        vector1[j] = Convert.ToInt32(Console.ReadLine());
                    else
                        vector2[j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int k = 0; k < 3; k++)
            {
                producto_escalar += vector1[k] * vector2[k];
            }

            Console.WriteLine("El producto escalar de ambos vectores es: {0}", producto_escalar);
        }
    }
}
