using System;

namespace Ejercicio_3_2_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 20, funcion = 0;

            for(int i=1;i<=n;i++)
            {
                funcion = ((Math.Pow(i, 2)) - 1);
                Console.Write("{0} ", funcion);
            }
        }
    }
}
