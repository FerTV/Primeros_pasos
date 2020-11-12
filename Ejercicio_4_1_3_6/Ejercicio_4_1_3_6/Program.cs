using System;

namespace Ejercicio_4_1_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            string nombre_a_encontrar;
            bool nombre_encontrado = false;

            for(int i=0;i<10;i++)
            {
                Console.Write("Introduce el nombre número {0}: ", i + 1);
                nombres[i] = Convert.ToString(Console.ReadLine());
            }

            do
            {
                Console.Write("Introduce el nombre a encontrar: ");
                nombre_a_encontrar = Convert.ToString(Console.ReadLine());

                for (int j = 0; j < 10; j++)
                {
                    if (nombres[j] == nombre_a_encontrar)
                    {
                        Console.WriteLine("El nombre se encuentra en el vector.");
                        nombre_encontrado = true;
                        break;
                    }
                }

                if (nombre_encontrado == false && nombre_a_encontrar!="fin")
                {
                    Console.WriteLine("El nombre no ha sido encontrado.");
                }

                nombre_encontrado = false;

            } while (nombre_a_encontrar != "fin");
        }
    }
}
