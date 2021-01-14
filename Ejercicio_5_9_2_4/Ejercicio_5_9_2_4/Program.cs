using System;

namespace Ejercicio_5_9_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int numero_a_buscar, numero_mayor=0, diferencia=0;
            bool mayor_encontrado = false, primera_vez=true;

            for(int i=0; i<5;i++)
            {
                Console.Write("Introduce el número {0}: ", i+1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nIntroduce el número a buscar: ");
            numero_a_buscar = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<5;i++)
            {
                if(numeros[i]>numero_a_buscar)
                {
                    if((numeros[i]-numero_a_buscar<diferencia)||primera_vez==true)
                    {
                        diferencia = numeros[i] - numero_a_buscar;
                        numero_mayor = numeros[i];
                        mayor_encontrado = true;
                        primera_vez = false;
                    }
                }
            }
            if (mayor_encontrado == true)
                Console.WriteLine("El número más cercano a {0} es {1}.", numero_a_buscar, numero_mayor);
            else
                Console.WriteLine("El número no ha sido encontrado");
        }
    }
}
