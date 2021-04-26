using System;
using System.IO;

namespace Ejercicio_8_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre_fichero, texto_buscar;

            using(StreamWriter fichero = new StreamWriter("prueba.txt"))
            {
                for(int i=0;i<100;i++)
                {
                    if (i % 10 == 0)
                        fichero.WriteLine("hola");
                    else
                        fichero.WriteLine();
                }
            }

            Console.Write("Introduce el nombre del fichero: ");
            nombre_fichero = Console.ReadLine();
            Console.Write("Introduce el nombre del texto a buscar: ");
            texto_buscar = Console.ReadLine();

            using (StreamReader ficheroR = new StreamReader(nombre_fichero))
            {
                string linea = ficheroR.ReadLine();

                for (int i = 0; linea != null; i++) 
                {
                    if(texto_buscar==linea)
                    {
                        Console.WriteLine("{0} {1}", i + 1, linea);
                    }
                }
            }
        }
    }
}
