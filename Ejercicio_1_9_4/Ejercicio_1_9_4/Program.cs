using System;

namespace Ejercicio_1_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int millas = 0;

            Console.Write("Introduce las millas a convertir a metros: ");
            millas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(millas + " millas son " + millas*1852 + " metros");

        }
    }
}
