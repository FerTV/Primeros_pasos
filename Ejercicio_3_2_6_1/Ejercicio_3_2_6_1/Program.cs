using System;

namespace Ejercicio_3_2_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            do
            {
                Console.Write("Introduce un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if(numero!=0)
                {
                    Console.Write("El número {0} en binario es: ", numero);
                    Console.WriteLine(Convert.ToString(numero, 2));
                    Console.Write("El número {0} en hexadecimal es: ", numero);
                    Console.WriteLine(Convert.ToString(numero, 16));
                }
            } while (numero != 0);
        }
    }
}
