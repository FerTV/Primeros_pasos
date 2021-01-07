using System;

namespace Ejercicio_5_7_2
{
    class Program
    {
        public static void Iniciales(string cadena, out char letra1, out char letra2)
        {
            char delimitador = ' ';
            string[] frase;

            frase = cadena.Split(delimitador);

            letra1 = frase[0][0];
            letra2 = frase[1][0];
        }
        static void Main(string[] args)
        {
            char letra1, letra2;
            string cadena;

            Console.Write("Introduce una cadena: ");
            cadena = Console.ReadLine();
            Iniciales(cadena, out letra1, out letra2);
            Console.WriteLine("La primera letra es {0} y la siguiente letra es {1}", letra1, letra2);
        }
    }
}
