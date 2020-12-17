using System;

namespace Ejericico_5_3_3
{
    class Program
    {
        public static void DibujarRectanguloHueco(int ancho, int alto, char c)
        {
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    if (i == 0 || i == alto - 1)
                        Console.Write(c);
                    else if (j == 0 || j == ancho - 1)
                        Console.Write(c);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int ancho, alto;
            char c;

            Console.Write("Introduce el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el alto: ");
            alto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Caracter con el que dibujar: ");
            c = Convert.ToChar(Console.ReadLine());
            DibujarRectanguloHueco(ancho, alto, c);
        }
    }
}
