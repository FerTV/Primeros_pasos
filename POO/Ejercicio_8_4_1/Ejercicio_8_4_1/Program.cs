using System;
using System.IO;

namespace Ejercicio_8_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamWriter fichero = new StreamWriter("log.txt",true))
            {
                string frase;

                do
                {
                    Console.Write("Introduce una frase: ");
                    frase = Console.ReadLine();

                    if (frase != "")
                    {
                        fichero.WriteLine(frase);
                    }
                } while (frase != "");
            }
        }
    }
}
