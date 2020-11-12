using System;

namespace Ejercicio_2_1_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;

            Console.Write("Introduce un número entre el 1 y el 5: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
                Console.WriteLine("El número introducido es el uno.");
            else if (n == 2)
                Console.WriteLine("El número introducido es el dos.");
            else if (n == 3)
                Console.WriteLine("El número introducido es el tres.");
            else if (n == 4)
                Console.WriteLine("El número introducido es el cuatro.");
            else if (n == 5)
                Console.WriteLine("El número introducido es el cinco.");
            else
                Console.WriteLine("El número introducido no esta comprendido entre el 1 y el 5.");
        }
    }
}
