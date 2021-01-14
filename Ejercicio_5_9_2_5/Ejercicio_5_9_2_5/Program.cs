using System;

namespace Ejercicio_5_9_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[5];
            double numero_a_buscar=0, diferencia=0, numero_mas_cercano=0;
            bool primera_vez=true;

            for(int i=0;i<5;i++)
            {
                Console.Write("Introduce el número {0}: ", i + 1);
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("\nIntroduce el número a buscar: ");
            numero_a_buscar = Convert.ToDouble(Console.ReadLine());
            numero_a_buscar = Math.Abs(numero_a_buscar);

            for(int i=0;i<5;i++)
            {
                if((Math.Abs(numero_a_buscar-Math.Abs(numeros[i]))<diferencia||primera_vez)&&numeros[i]!=numero_a_buscar)
                {
                    diferencia = Math.Abs(numero_a_buscar - Math.Abs(numeros[i]));
                    numero_mas_cercano = numeros[i];
                    primera_vez = false;
                }
            }
                Console.WriteLine("El número más cercano a {0} es {1}.", numero_a_buscar, numero_mas_cercano);
        }
    }
}
