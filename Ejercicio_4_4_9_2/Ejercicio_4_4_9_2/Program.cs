using System;
using System.Text;

namespace Ejercicio_4_4_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;

            Console.Write("Introduce una cadena: ");
            cadena = Console.ReadLine();

            StringBuilder cadenamodificable = new StringBuilder(cadena);

            for(int i=0; i<cadenamodificable.Length;i++)
            {
                if (i % 2 == 0)
                    cadenamodificable[i] = char.ToUpper(cadena[i]);
                else
                    cadenamodificable[i] = char.ToLower(cadena[i]);
            }
            Console.WriteLine("La cadena modificada es: {0}", cadenamodificable);
        }
    }
}
