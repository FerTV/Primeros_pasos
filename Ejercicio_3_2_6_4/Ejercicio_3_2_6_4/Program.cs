using System;

namespace Ejercicio_3_2_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string cadena;

            do
            {
                Console.Write("Escribe un número en binario: ");
                cadena = Convert.ToString(Console.ReadLine());

                if (cadena != "fin")
                {
                    n = Convert.ToInt32(cadena, 2);
                    
                    Console.Write("Su equivalente en hexadecimal es: ");
                    Console.WriteLine(Convert.ToString(n, 16));
                    Console.Write("Su equivalente en decimal es: ");
                    Console.WriteLine(n);
                }
            } while (cadena != "fin");
        }
    }
}
