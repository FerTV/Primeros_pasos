using System;

namespace Ejercicio_2_2_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1, cuadrado=0;

            while(numero!=0)
            {
                Console.Write("Introduce un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero != 0)
                {
                    cuadrado = numero * numero;
                    Console.WriteLine("El cuadrado de {0} es {1}.", numero, cuadrado);
                }
            }
        }
    }
}
