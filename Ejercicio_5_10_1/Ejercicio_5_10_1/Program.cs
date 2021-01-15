using System;

namespace Ejercicio_5_10_1
{
    class Program
    {
        public static int Potencia(int n, int potencia)
        {
            if (potencia == 1)
                return n;
            else
                return n * Potencia(n, potencia - 1);
        }
        static void Main(string[] args)
        {
            int n, potencia, resultado;

            Console.Write("Introduce un número: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce una potencia: ");
            potencia = Convert.ToInt32(Console.ReadLine());

            resultado = Potencia(n, potencia);

            Console.WriteLine("El resultado de {0} elevado a {1} es: {2}", n, potencia, resultado);
        }
    }
}
