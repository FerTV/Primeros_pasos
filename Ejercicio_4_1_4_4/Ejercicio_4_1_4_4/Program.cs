using System;

namespace Ejercicio_4_1_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 12, 6, 0 };
            int cantidad = 3;
            int capacidad = 5;
            int posicion;

            Console.Write("Posición del dato a borrar: ");
            posicion = Convert.ToInt32(Console.ReadLine());
            posicion--;

            if ((posicion < capacidad) && (cantidad < capacidad))
            {
                for (int i = posicion; i < cantidad + 1; i++)
                {
                    datos[i] = datos[i + 1];
                }
                cantidad--;
            }
            else
                Console.WriteLine("La posición escogida no es válida.");

            Console.Write("El vector es: ");
            for(int i=0;i<capacidad;i++)
            {
                Console.Write("{0} ", datos[i]);
            }
        }
    }
}
