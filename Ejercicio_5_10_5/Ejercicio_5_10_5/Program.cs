using System;

namespace Ejercicio_5_10_5
{
    class Program
    {
        public static int MaxVector(int[] vector, int pos, int mayor)
        {
            if (pos == 0)
            {
                if(vector[0]>mayor)
                {
                    mayor = vector[pos];
                    return mayor;
                }
                else
                {
                    return mayor;
                }
            }
            else
            {
                if (vector[pos] > mayor)
                    mayor = vector[pos];
                return MaxVector(vector, pos - 1, mayor);
            }
        }
        static void Main(string[] args)
        {
            const int KMAX = 3;
            int[] vector = new int[KMAX];
            int pos, mayor = 0;

            for (int i = 0; i < KMAX; i++)
            {
                Console.Write("Introduce el número {0}: ", i + 1);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Introduce hasta que posicion quieres sumar: ");
            pos = Convert.ToInt32(Console.ReadLine());

            mayor = MaxVector(vector, pos - 1, mayor);

            Console.WriteLine("El mayor de los elementos del vector hasta la posicion {0} es: {1}", pos, mayor);
        }
    }
}
