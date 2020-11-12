using System;

namespace Ejercicio_2_2_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Los múltiplos de 9 entre 1 y {0} son: ", numero);

            for (int i = 1; i <= numero; i++)
            {
                if(i%9==0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
