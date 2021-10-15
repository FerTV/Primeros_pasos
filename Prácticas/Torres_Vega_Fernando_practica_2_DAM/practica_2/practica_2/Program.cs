// --------------------------------------------
// Fernando Torres Vega
// Curso DAM
// Modalidad Presencial
// Práctica nº 2
// --------------------------------------------
using System;
using System.Text;

namespace practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            char letra = ' ';
            bool letra_correcta = false;
            int error = 0 /*numero_letras_introducidas = 0*/;

            Console.Write("Cadena: ");
            cadena = Console.ReadLine();
            Console.WriteLine();

            StringBuilder palabra_formada = new StringBuilder(cadena);

            for (int i = 0; i < cadena.Length; i++)
            {
                palabra_formada[i] = '_';
            }
            do
            {
                //Compruebo que la letra se ha introducido correctamente
                do
                {
                    try
                    {
                        Console.Write("Letra: ");
                        letra = Convert.ToChar(Console.ReadLine());
                        letra_correcta = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error al introducir la letra.");
                    }
                } while (!letra_correcta);

                letra_correcta = false;

                if (cadena.ToLower().Contains(char.ToLower(letra)))
                {
                    for (int i = 0; i < cadena.Length; i++)
                    {
                        if (cadena.ToLower()[i] == char.ToLower(letra))
                        {
                            if (cadena[i] == letra)
                                palabra_formada[i] = letra;
                            else if (cadena[i] == char.ToLower(letra))
                                palabra_formada[i] = char.ToLower(letra);
                            else
                                palabra_formada[i] = char.ToUpper(letra);
                        }
                    }
                }
                else
                {
                    error++;

                    switch (error)
                    {
                        case 1:
                            Console.WriteLine("┌───┐   ");
                            Console.WriteLine("│   o   ");
                            Console.WriteLine("│       ");
                            Console.WriteLine("│       ");
                            Console.WriteLine("│       ");
                            Console.WriteLine("┴───────");
                            break;
                        case 2:
                            Console.WriteLine("┌───┐   ");
                            Console.WriteLine("│   o   ");
                            Console.WriteLine("│  /    ");
                            Console.WriteLine("│       ");
                            Console.WriteLine("│       ");
                            Console.WriteLine("┴───────");
                            break;
                        case 3:
                            Console.WriteLine("┌───┐   ");
                            Console.WriteLine("│   o   ");
                            Console.WriteLine("│  /|   ");
                            Console.WriteLine("│       ");
                            Console.WriteLine("│       ");
                            Console.WriteLine("┴───────");
                            break;
                        case 4:
                            Console.WriteLine("┌───┐   ");
                            Console.WriteLine("│   o   ");
                            Console.WriteLine("│  /|\\ ");
                            Console.WriteLine("│       ");
                            Console.WriteLine("│       ");
                            Console.WriteLine("┴───────");
                            break;
                        case 5:
                            Console.WriteLine("┌───┐   ");
                            Console.WriteLine("│   o   ");
                            Console.WriteLine("│  /|\\ ");
                            Console.WriteLine("│  /    ");
                            Console.WriteLine("│       ");
                            Console.WriteLine("┴───────");
                            break;
                        case 6:
                            Console.WriteLine("┌───┐   ");
                            Console.WriteLine("│   o   ");
                            Console.WriteLine("│  /|\\ ");
                            Console.WriteLine("│  / \\ ");
                            Console.WriteLine("│       ");
                            Console.WriteLine("┴───────");
                            break;
                        default:
                            break;
                    }
                }

                for (int i = 0; i < palabra_formada.Length; i++)
                {
                    Console.Write("{0} ", palabra_formada[i]);
                }

                Console.WriteLine("\n");

            } while (error < 6 && palabra_formada.ToString().Contains('_'));

            if (error == 6)
                Console.WriteLine("\nR.I.P. La palabra era: {0}.", cadena);
            else
                Console.WriteLine("\n¡¡¡ENHORABUENA!!!");
        }
    }
}
