using System;

namespace Ejercicio_2_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, solucion = 0, exponente=0;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce su exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            if(exponente!=0)
                solucion = numero;

            for (int i = 1; i < exponente; i++)
            {
                solucion = solucion * numero;
            }

            Console.WriteLine("{0} elevado a {1} es: {2}.", numero, exponente, solucion);
        }
    }
}
