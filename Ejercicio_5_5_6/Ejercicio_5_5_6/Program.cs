using System;

namespace Ejercicio_5_5_6
{
    class Program
    {
        public static void DibujarTriangulo(int ancho, char caracter)
        {
            int alto = ancho;

            for(int i=0;i<alto;i++)
            {
                for(int j=0;j<ancho;j++)
                {
                    Console.Write("{0}", caracter);
                }
                ancho--;
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int ancho;
            char caracter;

            Console.Write("Introduce la anchura del triángulo: ");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el cáracter con el que dibujar: ");
            caracter = Convert.ToChar(Console.ReadLine());
            DibujarTriangulo(ancho, caracter);
        }
    }
}
