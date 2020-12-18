using System;

namespace Ejercicio_5_5_5
{
    class Program
    {
        public static int SumaCifras(int numero)
        {
            int suma = numero % 10;

            do
            {
                numero = numero / 10;
                suma += numero % 10;
            } while (numero / 10 != 0);

            return suma;
        }
        static void Main(string[] args)
        {
            int numero, suma;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            suma = SumaCifras(numero);
            Console.WriteLine("La suma de las cifras de {0} es: {1}", numero, suma);
        }
    }
}
