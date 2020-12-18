using System;

namespace Ejercicio_5_5_2
{
    class Program
    {
        public static void EscribirTablaMultiplicar(int numero)
        {
            int multiplicacion;

            Console.WriteLine("La tabla de multiplicar del {0} es: ", numero);

            for (int i = 0; i <= 10; i++)
            {
                multiplicacion = numero * i;
                Console.WriteLine("{0}x{1}={2}", numero, i, multiplicacion);
            }
        }
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            EscribirTablaMultiplicar(numero);
        }
    }
}
