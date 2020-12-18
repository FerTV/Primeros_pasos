using System;

namespace Ejercicio_5_4_6
{
    class Program
    {
        public static void MostrarPerimSuperfCuadrado(int n)
        {
            int perimetro, superficie;

            perimetro = 4 * n;
            superficie = (int)Math.Pow(n, 2);

            Console.WriteLine("La superficie del cuadrado es: {0}", superficie);
            Console.WriteLine("El perímetro del cuadrado es: {0}", perimetro);
        }
        static void Main(string[] args)
        {
            int lado_cuadrado;

            Console.Write("Introduce el lado del cuadrado: ");
            lado_cuadrado = Convert.ToInt32(Console.ReadLine());
            MostrarPerimSuperfCuadrado(lado_cuadrado);
        }
    }
}
