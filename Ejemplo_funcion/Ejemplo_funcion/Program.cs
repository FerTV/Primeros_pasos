using System;

namespace Ejemplo_funcion
{
    class Program
    {
        public static int Sumar(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = 0; //Se incializa a cero porque es el neutro de la suma.

            c = Sumar(a, b);

            Console.WriteLine(c);

            int p = 9;

            c = Sumar(c, p);

            Console.WriteLine(c);
        }
    }
}
