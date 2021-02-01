using System;

namespace Ejercicio_5_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, n1, n2;

            if(args.Length<=0)
            {
                Console.WriteLine("No hay suficientes datos.");
            }
            else if(args.Length<2)
            {
                Console.WriteLine(args[0]);
            }
            else if(args.Length>=2)
            {
                n1 = Convert.ToInt32(args[0]);
                n2 = Convert.ToInt32(args[1]);
                suma = n1 + n2;
                Console.WriteLine(suma);
            }
        }
    }
}
