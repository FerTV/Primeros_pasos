using System;

namespace Ejercicio_5_5_1
{
    class Program
    {
        public static int PedirEntero(string cadena, int min, int max)
        {
            int numero;

            do
            {
                Console.Write(cadena);
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero < min || numero > max);

            return numero;
        }
        static void Main(string[] args)
        {
            string texto;
            int minvalue, maxvalue, numero;

            Console.Write("Introduce el texto a pedir: ");
            texto = Console.ReadLine();
            Console.Write("Introduce el valor mínimo: ");
            minvalue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el valor máximo: ");
            maxvalue = Convert.ToInt32(Console.ReadLine());

            numero = PedirEntero(texto, minvalue, maxvalue);

            Console.WriteLine("El número es: {0}", numero);
        }
    }
}
