using System;

namespace Ejercicio_3_2_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double raiz = 0;
            float resultado = 0;

            Console.Write("introduce un número: ");
            raiz = Convert.ToDouble(Console.ReadLine());

            resultado = (float)Math.Sqrt(raiz);

            Console.WriteLine("El resultado de la raíz cuadrada de {0} es {1}.", raiz, resultado);
        }
    }
}
