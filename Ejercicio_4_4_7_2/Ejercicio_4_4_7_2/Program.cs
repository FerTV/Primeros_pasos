using System;

namespace Ejercicio_4_4_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena_numerica;
            char delimitador = ' ';
            int suma=0;

            Console.Write("Introduce los números a sumar: ");
            cadena_numerica = Console.ReadLine();

            string[] numero = cadena_numerica.Split(delimitador);

            for (int i = 0; i < numero.Length; i++)
            {
                suma += Convert.ToInt32(numero[i]);
            }
            Console.WriteLine("La suma es: {0}", suma);
        }
    }
}
