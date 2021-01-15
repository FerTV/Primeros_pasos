using System;

namespace Ejercicio_5_9_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double angulo;

            Console.Write("Introduce un ángulo: ");
            angulo = Convert.ToDouble(Console.ReadLine());

            angulo = angulo*(Math.PI/180);
            Console.WriteLine("El coseno del ángulo es: " + Math.Round( Math.Cos(angulo)));
            Console.WriteLine("El seno del ángulo es: " + Math.Round(Math.Sin(angulo)));
            Console.WriteLine("La tangente del ángulo es: " + Math.Round(Math.Tan(angulo)));
        }
    }
}
