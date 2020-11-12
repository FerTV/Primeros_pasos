using System;

namespace Ejercicio_4_1_3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[3];
            int[] vector2 = new int[3];
            int[] vector_suma = new int[3];
            
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("Introduce el vector {0}", i + 1);

                for(int j=0;j<3;j++)
                {
                    Console.Write(" componente {0}: ", j + 1);

                    if (i == 0)
                        vector1[j] = Convert.ToInt32(Console.ReadLine());
                    else
                        vector2[j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("La suma de ambos vectores es: ");

            for(int i=0;i<3;i++)
            {
                vector_suma[i] = vector1[i] + vector2[i];
                Console.Write("x{0}+y{0}={1} ", i + 1, vector_suma[i]);
            }
        }
    }
}
