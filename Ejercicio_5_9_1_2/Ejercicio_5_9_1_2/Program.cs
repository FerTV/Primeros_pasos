using System;

namespace Ejercicio_5_9_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generador = new Random();
            int num_aleatorio = generador.Next(1, 101);
            int numero;

            for (int error = 0; error < 6; error++)
            {
                Console.Write("Introduce un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == num_aleatorio)
                {
                    Console.WriteLine("ENHORABUENA!!!");
                    break;
                }
                else
                    Console.WriteLine("Mejor suerte la próxima vez");
            }
        }
    }
}
