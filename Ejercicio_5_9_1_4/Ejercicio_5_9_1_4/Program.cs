using System;

namespace Ejercicio_5_9_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            Random r = new Random();
            int aleatorio, media, suma = 0;

            for (int i = 0; i < 100; i++)
            {
                aleatorio = r.Next(-1000, 1001);
                numeros[i] = aleatorio;
                suma += numeros[i];
            }
            media = suma / 100;

            Console.WriteLine("La media de los números aleatorios es: {0}", media);
        }
    }
}
