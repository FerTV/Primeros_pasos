using System;

namespace Ejercicio_palabra_dentro_frase
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string palabra;
            int contador = 0;

            Console.Write("Introduce la frase: ");
            frase = Console.ReadLine();

            Console.Write("Introduce la palabra: ");
            palabra = Console.ReadLine();

            for (int i = 0; (i < frase.Length) && (i != -1); i++)
            {
                if (frase.IndexOf(palabra, i) >= 0)
                {
                    contador++;
                    i = frase.IndexOf(palabra, i);
                }
            }
            Console.WriteLine("La palabra se encuentra {0} veces en la frase.",contador);
        }
    }
}
