using System;

namespace Ejercicio_3_2_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double volumen = 0, radio = 0;
            float pi = 3.14f;

            Console.Write("Introduce el radio de la esfera: ");
            radio = Convert.ToDouble(Console.ReadLine());

            volumen = pi * (Math.Pow(radio, 3)) * 4 / 3;

            Console.WriteLine("El volumen de la esfera es: {0}.", volumen);
        }
    }
}
