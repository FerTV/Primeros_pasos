using System;

namespace Ejercicio_1_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.Write("Introduce el primer numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el tercer numero: ");
            numero3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado de la suma de los 3 números es: " + (numero1+numero2+numero3));
        }
    }
}
