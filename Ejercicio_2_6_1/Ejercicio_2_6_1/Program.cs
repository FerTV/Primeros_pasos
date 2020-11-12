using System;

namespace Ejercicio_2_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int adivinar = 50, numero_introducido = 0;

            for (int i = 0; ((numero_introducido != adivinar) && (i < 6)); i++)
            {
                Console.Write("Introduce un número: ");
                numero_introducido = Convert.ToInt32(Console.ReadLine());

                if (numero_introducido == adivinar)
                    Console.WriteLine("Enhorabuena has adivinado el número!!!");
                else if (numero_introducido > adivinar)
                    Console.WriteLine("El número introducido es mayor que el número a adivinar.");
                else
                    Console.WriteLine("El número introducido es menor que el número a adivinar.");
            }
        }
    }
}
