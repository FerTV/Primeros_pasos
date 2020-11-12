using System;

namespace Ejercicio_4_1_3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            int mayor;
            // int mayor = int32.MinValue coge el valor mínimo del rango de representación!!!!

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Introduce el número {0}: ", i+1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            mayor = numeros[0];

            for (int j = 1; j < 4; j++)
            {
                if (mayor < numeros[j])
                    mayor = numeros[j];
            }

            Console.WriteLine("El número más grande de los introducidos es: {0}.", mayor);
        }
    }
}
