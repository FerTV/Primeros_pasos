using System;

namespace Ejercicio_3_2_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.14f, area=0;
            int radio = 0;

            Console.Write("Introduce el radio del círculo: ");
            radio = Convert.ToInt32(Console.ReadLine());

            area = pi * (radio * radio);

            Console.WriteLine("El área del círculo es: {0}.", area);
        }
    }
}
