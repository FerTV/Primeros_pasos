using System;

namespace Ejercicio_2_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0, nacimiento = 0;

            try
            {
                Console.Write("Introduce tu edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception errorencontrado)
            {
                Console.WriteLine("Ha habido un error: {0}", errorencontrado.Message);
            }
            try
            {
                Console.Write("Introduce tu año de nacimiento: ");
                nacimiento = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception errorencontrado)
            {
                Console.WriteLine("Ha habido un error: {0}", errorencontrado.Message);
            }
        }
    }
}
