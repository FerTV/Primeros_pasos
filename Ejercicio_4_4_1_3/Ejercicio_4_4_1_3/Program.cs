using System;

namespace Ejercicio_4_4_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, dia_nacimiento, mes_nacimiento;

            Console.Write("Introduce tu nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Introduce tu dia de nacimiento: ");
            dia_nacimiento = Console.ReadLine();

            Console.Write("Introduce tu mes de nacimiento: ");
            mes_nacimiento = Console.ReadLine();

            Console.WriteLine("Tus datos son: {0}, nacido el {1}/{2}", nombre, dia_nacimiento, mes_nacimiento);
        }
    }
}
