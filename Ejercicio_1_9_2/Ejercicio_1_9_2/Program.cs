using System;

namespace Ejercicio_1_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int divisor = 1;
            int division = 0;
            int resto = 0;

            Console.Write("Introduce el numero a dividir: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el divisor:");
            divisor = Convert.ToInt32(Console.ReadLine());
            division = numero / divisor;
            resto = numero % divisor;

            Console.WriteLine("El resultado de la division es: {0}", division);
            Console.WriteLine("El resto de la division es: {0}", resto);
        }
    }
}
