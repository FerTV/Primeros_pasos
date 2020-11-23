using System;

namespace Ejercicio_4_4_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            int longitud;

            Console.Write("Introduce una frase:");
            frase = Console.ReadLine();

            longitud = frase.Length;

            Console.WriteLine("longitud" +longitud);

            for(int i=0;i<longitud-1;i++)
            {
                Console.WriteLine(i);
                if (frase[i] == ' ')
                {
                    frase = frase.Remove(i, 1);
                }
            }

            Console.WriteLine("La frase resultante:{0}", frase);
        }
    }
}
