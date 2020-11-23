using System;

namespace Ejercicio_4_4_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM_MAX = 5;
            string[] cadena = new string[TAM_MAX];
            string cadena_mayor="";

           for(int i=0;i<TAM_MAX;i++)
           {
                Console.Write("Introduce la cadena {0}: ", i + 1);
                cadena[i] = Console.ReadLine();

                if (i > 0)
                {
                    if (string.Compare(cadena[i], cadena_mayor, true) > 0)
                    {
                        cadena_mayor = cadena[i];
                    }
                }
                else
                    cadena_mayor = cadena[i];
           }
            Console.WriteLine("La cadena mayor es: {0}", cadena_mayor);
        }
    }
}
