using System;

namespace Ejercicio_5_10_2
{
    class Program
    {
        public static int Potencia(int n, int potencia)
        {
            int resultado = 0; 

            for(int i=1;i<potencia;i++)
            {
                if (i == 1)
                    resultado = resultado + (n * n);
                else
                    resultado = resultado * n;
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            int numero, potencia, resultado;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce una potencia: ");
            potencia = Convert.ToInt32(Console.ReadLine());

            resultado = Potencia(numero, potencia);

            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
