using System;
using System.IO;

namespace binario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string extension = "";

            Console.Write("Introduce el nombre del fichero: ");
            nombre = Console.ReadLine();
            FileStream fichero = File.OpenRead(nombre);

            for (int pos = 0; pos < 10; pos++)
            {
                extension = extension + Convert.ToChar((byte)fichero.ReadByte());
            }
            Console.WriteLine("Los 50 primeros bytes son {0}", extension);
            fichero.Close();
        }
    }
}
