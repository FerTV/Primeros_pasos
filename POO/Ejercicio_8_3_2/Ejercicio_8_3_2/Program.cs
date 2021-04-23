using System;
using System.IO;

namespace Ejercicio_8_3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string linea;
            using (StreamReader fichero = new StreamReader("prueba.txt"))
            {
                do
                {
                    linea = fichero.ReadLine();
                    if (linea != null)
                        Console.WriteLine(linea);
                }
                while (linea != null);
            }
        }
    }
}
