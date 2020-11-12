using System;

namespace Ejercicio_4_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            int index;
            double media = 0;

            Console.Write("¿Cuantos números vas a introducir? ");
            index = Convert.ToInt32(Console.ReadLine());

            numeros = new int[index];

            for(int i=0;i<index;i++)
            {
                Console.Write("Introduce el numero {0}: ", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                media += numeros[i];
            }
            media = media / index;
            Console.WriteLine("La media de los números es: {0}.", media);
        }
    }
}
