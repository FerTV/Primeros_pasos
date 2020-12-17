using System;

namespace Ejercicio_5_4_1
{
    class Program
    {
        public static float Cubo(float n)
        {
            return (float)Math.Pow(n,3);
        }
        static void Main(string[] args)
        {
            float numero, cubo;

            Console.Write("Introduce un número: ");
            numero = Convert.ToSingle(Console.ReadLine());
            cubo = Cubo(numero);
            Console.Write("El cubo de {0} es: {1}", numero, cubo);
        }
    }
}
