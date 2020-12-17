using System;

namespace Ejercicio_5_4_4
{
    class Program
    {
        public static char Inicial(string cadena)
        {
            char c;

            return c = cadena[0];
        }
        static void Main(string[] args)
        {
            string cadena;
            char PrimeraLetra;

            Console.Write("Introduce una cadena: ");
            cadena = Console.ReadLine();
            PrimeraLetra = Inicial(cadena);
            Console.WriteLine("La primera letra es: {0}", PrimeraLetra);
        }
    }
}
