using System;

namespace Ejercicio_3_3_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho, alto;
            char letra;

            Console.Write("Introduce el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el alto: ");
            alto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce la letra a escribir: ");
            letra = Convert.ToChar(Console.ReadLine());

            for(int i=0;i<alto;i++)
            {
                for(int j=0;j<ancho;j++)
                {
                    Console.Write(letra);
                }
                Console.WriteLine();
            }
        }
    }
}
