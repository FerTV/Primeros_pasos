using System;

namespace Ejercicio_5_10_4
{
    class Program
    {
        public static int SumaVector(int[] vector, int pos)
        {
            if (pos==1)
            {
                return vector[0];
            }
            else
            {
                return vector[pos-1] + SumaVector(vector, pos - 1);
            }
        }
        static void Main(string[] args)
        {
            const int KMAX = 3;
            int[] vector = new int[KMAX];
            int pos, suma;

            for(int i=0;i<KMAX;i++)
            {
                Console.Write("Introduce el número {0}: ", i + 1);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Introduce hasta que posicion quieres sumar: ");
            pos = Convert.ToInt32(Console.ReadLine());

            suma = SumaVector(vector, pos);

            Console.WriteLine("La suma de los elementos del vector hasta la posicion {0} es: {1}", pos, suma);
        }
    }
}

