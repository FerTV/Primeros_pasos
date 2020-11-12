using System;

namespace Ejercicio_2_6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio = 0, pagado = 0, cambio = 0;

            Console.Write("Precio? ");
            precio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Pagado? ");
            pagado = Convert.ToInt32(Console.ReadLine());

            cambio = pagado - precio;
            Console.Write("Su cambio es de {0}: ", cambio);

            while(cambio>0)
            {
                if (cambio >= 100)
                {
                    Console.Write("100 ");
                    cambio = cambio - 100;
                }
                else if(cambio>=50)
                {
                    Console.Write("50 ");
                    cambio = cambio - 50;
                }
                else if(cambio>=20)
                {
                    Console.Write("20 ");
                    cambio = cambio - 20;
                }
                else if(cambio>=10)
                {
                    Console.Write("10 ");
                    cambio = cambio - 10;
                }
                else if(cambio>=5)
                {
                    Console.Write("5 ");
                    cambio = cambio - 5;
                }
                else if(cambio>=2)
                {
                    Console.Write("2 ");
                    cambio = cambio - 2;
                }
                else
                {
                    Console.Write("1 ");
                    cambio = cambio - 1;
                }
            }
        }
    }
}
