using System;

namespace Ejercicio_3_1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte n1 = 0, n2 = 0;
            short resultado = 0;

            Console.Write("Introduce el primer número: ");
            n1 = Convert.ToSByte(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            n2 = Convert.ToSByte(Console.ReadLine());

            resultado = Convert.ToInt16(n1 * n2);

            Console.WriteLine("El resultado de multiplicar {0} por {1} es: {2}.", n1, n2, resultado);
        }
    }
}
