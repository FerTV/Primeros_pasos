using System;

namespace Ejercicio_5_9_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generador = new Random();
            int dado = generador.Next(1, 7);
            int numero;

            do
            {
                Console.Write("Introduce un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == dado)
                {
                    Console.WriteLine("ENHORABUENA!!!");
                    break;
                }
                else
                    Console.WriteLine("Mala suerte prueba de nuevo");
            } while (numero != 0);
        }
    }
}
