using System;

namespace Ejercicio_4_1_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 15, 0, 0 };
            int cantidad = 3;
            int capacidad = 5;
            int dato_a_anyadir;

            Console.Write("Introduce el número a añadir: ");
            dato_a_anyadir = Convert.ToInt32(Console.ReadLine());

            if (cantidad < capacidad)
            {
                datos[cantidad + 1] = dato_a_anyadir;
                cantidad++;
            }
        }
    }
}
