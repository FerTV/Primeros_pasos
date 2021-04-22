using System;
using System.IO;

namespace Ejercicio_8_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "";

            using (StreamWriter fichero = new StreamWriter("registroDeUsuario.txt"))
            {
                while (frase.ToLower() != "fin")
                {
                    if (frase != "")
                    {
                        fichero.WriteLine(frase);
                    }
                    frase = Console.ReadLine();
                }
            }
        }
    }
}
