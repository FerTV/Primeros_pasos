using System;

namespace Ejercicio_5_4_5
{
    class Program
    {
        public static char UltimaLetra(string cadena)
        {
            char c;

            return c = cadena[cadena.Length];
        }
        static void Main(string[] args)
        {
            string cadena;
            char PrimeraLetra;

            Console.Write("Introduce una cadena: ");
            cadena = Console.ReadLine();
            PrimeraLetra = UltimaLetra(cadena);
            Console.WriteLine("La última letra es: {0}", PrimeraLetra);
        }
    }
}
