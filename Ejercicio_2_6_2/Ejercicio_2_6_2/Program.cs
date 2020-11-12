using System;

namespace Ejercicio_2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, divisor = 2;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0} = ", numero);
            /*
            while(numero==numero)
            {
                if (numero % divisor == 0)
                {
                    numero = numero / divisor;
                    Console.Write("{0} * ", divisor);
                }
                else if (numero / divisor == 1)
                {
                    Console.Write(numero);
                    break;
                }
                else
                    divisor++;
            }
            */
            while (numero != 1)
            {
                if (numero % divisor == 0)
                {
                    Console.Write("{0} ", divisor);
                    numero = numero / divisor;
                }
                else
                    divisor++;
            }
        }
    }
}
