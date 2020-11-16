using System;

namespace Ejercicio_4_4_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Escribe tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Tu nombre es: ");
            for(int i=0;i<5;i++)
            {
                Console.Write("{0} ", nombre);
            }
        }
    }
}
