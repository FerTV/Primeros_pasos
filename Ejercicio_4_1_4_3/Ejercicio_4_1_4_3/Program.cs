using System;

namespace Ejercicio_4_1_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 15, 0, 0 };
            int cantidad = 3;
            int capacidad = 5;
            int dato_a_insertar;
            int posicion = 0;

            Console.Write("Dato a insertar: ");
            dato_a_insertar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Posición en la que se va a insertar el dato: ");
            posicion = Convert.ToInt32(Console.ReadLine());

            posicion--;

            if ((posicion < capacidad) && (cantidad < capacidad))
            {
                for (int i = 0; i > posicion; i--)
                {
                    datos[i] = datos[i - 1];
                }
                datos[posicion] = dato_a_insertar;
                cantidad++;
            }
            else
            {
                Console.WriteLine("La posición escogida es incorrecta.");
            }
        }
    }
}
