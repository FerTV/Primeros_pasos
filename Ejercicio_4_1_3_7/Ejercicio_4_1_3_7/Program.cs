using System;

namespace Ejercicio_4_1_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[100];
            int i;

            for(i=0;i<100;i++)
            {
                Console.Write("Introduce el nombre {0}: ", i + 1);
                nombres[i] = Convert.ToString(Console.ReadLine());

                if (nombres[i] == "")
                    break;
            }

            Console.WriteLine("\nLa lista de los nombres introducidos es: ");

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("Nombre {0}: {1}", j + 1, nombres[j]);
            }
        }
    }
}
