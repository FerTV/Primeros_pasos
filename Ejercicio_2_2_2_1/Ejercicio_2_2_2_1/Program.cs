using System;

namespace Ejercicio_2_2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0, suma=0;

            do
            {

                Console.Write("Introduce un número positivo y mayor que cero: ");
                n = Convert.ToInt32(Console.ReadLine());

                if(n>0)
                suma = suma + n;
                Console.WriteLine("La suma de los números introducidos es: {0}", suma);

            } while (n != 0 && n > 0);
        }
    }
}
