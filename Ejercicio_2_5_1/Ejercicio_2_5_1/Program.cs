using System;

namespace Ejercicio_2_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "0";
            int aparece_letraa = 0;

            Console.Write("Introduce una frase: ");
            cadena = Console.ReadLine();

            foreach(char letra in cadena)
            {
                if(letra=='a')
                {
                    aparece_letraa++;
                }
            }
            Console.WriteLine("La letra a aparece {0} veces.",aparece_letraa);
        }
    }
}
