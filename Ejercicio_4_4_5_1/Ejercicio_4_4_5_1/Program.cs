using System;

namespace Ejercicio_4_4_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM_FRASES = 10;
            string[] frase = new string[NUM_FRASES];
            string texto_buscar;

            for(int i=0;i<NUM_FRASES;i++)
            {
                Console.Write("Introduce la frase {0}: ", i + 1);
                frase[i] = Console.ReadLine();
            }

            do
            {
                Console.Write("Introduce el texto a buscar: ");
                texto_buscar = Console.ReadLine();

                for(int i=0;i<NUM_FRASES;i++)
                {
                    if (frase[i].Contains(texto_buscar))
                        Console.WriteLine("El texto a buscar aparece en la frase {0}", i + 1);
                }
            } while (texto_buscar != "fin");
        }
    }
}
