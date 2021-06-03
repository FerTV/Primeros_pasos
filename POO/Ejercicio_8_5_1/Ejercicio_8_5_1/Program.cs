using System;
using System.IO;

namespace Ejercicio_8_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            void suma(int n1, int n2)
            {
                Console.WriteLine(n1+n2);
            }

            int suma1(int n1, int n2)
            {       
                return n1+n2;
            }

            using (StreamWriter fichero = new StreamWriter(".\\resultados\\sumas.txt", true))
             {
                int n1, n2, suma;

                Console.Write("Introduce el n1: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce el n2: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                suma = n1 + n2;
                Console.WriteLine("{0} + {1} = {2}", n1, n2, suma);
                fichero.WriteLine("{0} + {1} = {2}", n1, n2, suma);
             }

            int n1=2, n2=3, resultado;

            suma(n1,n2);
            resultado=suma1(n1, n2);

            

            Console.WriteLine(resultado*2);
            
        }
    }
}
