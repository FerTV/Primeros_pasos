using System;

namespace Ejercicio_2_2_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 1;

            while(i<4)
            {
                while(j<=5)
                {
                    Console.Write(j);
                    j++;
                }
                i++;
                j = 1;
            }
        }
    }
}
