using System;

namespace Ejercicio_5_5_4
{
    class Program
    {
        public static int ContarLetra(string cadena, char letra)
        {
            int repeticiones=0;

            cadena = cadena.ToLower();
            for(int i=0;i<cadena.Length;i++)
            {
                if (cadena[i] == letra)
                    repeticiones++;
            }
            return repeticiones;
        }
        static void Main(string[] args)
        {
            string cadena;
            int repeticiones;
            char letra;

            Console.Write("Introduce una cadena: ");
            cadena = Console.ReadLine();
            Console.Write("Introduce la letra: ");
            letra = Convert.ToChar(Console.ReadLine());
            repeticiones = ContarLetra(cadena, letra);
            Console.WriteLine("La letra \"{0}\" se repite {1} veces.", letra, repeticiones);
        }
    }
}
