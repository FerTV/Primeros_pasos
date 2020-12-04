using System;
using System.Text;

namespace Ejercicio_4_4_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;

            Console.Write("Introduce una cadena: ");
            cadena = Console.ReadLine();

            StringBuilder cadenamodificable = new StringBuilder(cadena);

            for (int i = 0; i < cadenamodificable.Length; i++) 
            {
                if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'u')
                    cadenamodificable[i] = 'o';
            }
            Console.WriteLine("La cadena modificada es: {0}", cadenamodificable);
        }
    }
}
