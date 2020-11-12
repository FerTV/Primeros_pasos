using System;

namespace Ejercicio_3_2_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double ancho = 0, alto = 0, perimetro = 0, area = 0, diagonal = 0, c1=0, c2=0;

            Console.Write("Introduce el ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el alto: ");
            alto = Convert.ToDouble(Console.ReadLine());

            Console.Write("El perimetro es: ");
            perimetro = (2 * alto) + (2 * ancho);
            Console.WriteLine(perimetro.ToString("N1"));
            Console.Write("El área es: ");
            area = ancho * alto;
            Console.WriteLine(area.ToString("N1"));
            Console.Write("La diagonal es: ");
            c1 = Math.Pow(ancho, 2);
            c2 = Math.Pow(alto, 2);
            diagonal = c1 + c2;
            diagonal = Math.Sqrt(diagonal);
            Console.WriteLine(diagonal.ToString("N1"));

        }
    }
}
