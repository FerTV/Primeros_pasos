using System;

namespace Ejercicio_3_2_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio = 0, r2 = 0, r3 = 0, superficie = 0, volumen = 0, pi=3.14;

            Console.Write("Introduce el radio de la esfera: ");
            radio = Convert.ToDouble(Console.ReadLine());

            r2 = Math.Pow(radio, 2);
            r3 = Math.Pow(radio, 3);

            Console.Write("La superficie de la esfera es: ");
            superficie = 4 * pi * r2;
            Console.WriteLine(superficie.ToString("N5"));
            Console.Write("El volumen de la esfera es: ");
            volumen = 4 / 3 * pi * r3;
            Console.WriteLine(volumen.ToString("N5"));
        }
    }
}
