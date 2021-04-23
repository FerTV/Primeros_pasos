using System;
using System.IO;

namespace Ejercicio_8_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre_fichero;
            string linea="";

            Console.Write("Introduce el nombre del fichero: ");
            nombre_fichero = Console.ReadLine();

            using(StreamReader fichero = new StreamReader(nombre_fichero))
            {
                do
                {

                    for (int i = 0; i < 24 && linea != null; i++) 
                    {
                        linea = fichero.ReadLine();
                        if (linea != null)
                            Console.WriteLine(linea);
                    }
                    if(linea!=null)
                    Console.ReadLine();
                } while (linea != null);
            }
        }
    }
}
