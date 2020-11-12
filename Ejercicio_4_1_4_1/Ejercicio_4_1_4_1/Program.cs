using System;

namespace Ejercicio_4_1_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 15, 0, 0 };
            int cantidad = 3;
            int dato_a_buscar;
            int num_veces = 0;
            bool dato_encontrado = false;

            Console.Write("Introduce el dato a buscar: ");
            dato_a_buscar = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<cantidad;i++)
            {
                if (dato_a_buscar == datos[i])
                {
                    dato_encontrado = true;
                    num_veces++;
                }
            }

            if (dato_encontrado)
            {
                Console.WriteLine("El dato {0}, se ha encontrado {1} veces.", dato_a_buscar, num_veces);
            }
            else
                Console.WriteLine("El dato no ha sido encontrado.");
        }
    }
}
