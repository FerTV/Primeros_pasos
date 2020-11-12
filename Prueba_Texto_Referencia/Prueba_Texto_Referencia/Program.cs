using System;

namespace Prueba_Texto_Referencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 3;
            int sumaab = a + b;
            int sumaaa = a + a;

            Console.WriteLine("La suma de {0} más {0} es {1}",a,sumaaa);
            Console.WriteLine("La suma de {0} más {1} es {2}", a, b, sumaab);
        }
    }
}
