using System;
using System.IO;

namespace Ejercicio_8_2_3
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

            using (StreamReader fichero = new StreamReader("registroDeUsuario.txt"))
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(fichero.ReadLine());
                }
            }

        }
    }
}