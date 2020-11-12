using System;

namespace Ejercicio_4_3_1_1
{
    class Program
    {
        struct cancion
        {
            public string artista;
            public string titulo;
            public int duracion;
            public int tam;
        }
        static void Main(string[] args)
        {
            cancion cancionMP3;

            Console.Write("Introduce el Artista: ");
            cancionMP3.artista = Convert.ToString(Console.ReadLine());

            Console.Write("Introduce el título: ");
            cancionMP3.titulo = Convert.ToString(Console.ReadLine());

            do
            {
                try
                {
                    Console.Write("Introduce la duracion en segundos: ");
                    cancionMP3.duracion = Convert.ToInt32(Console.ReadLine());

                    if (cancionMP3.duracion < 1 || cancionMP3.duracion > 60)
                        throw new Exception("La duracion debe estar en segundos.");
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);

            Console.Write("Introduce el tamaño en KB: ");
            cancionMP3.tam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los datos introducidos son: \n");
            Console.WriteLine("Artista: {0}", cancionMP3.artista);
            Console.WriteLine("Título: {0}", cancionMP3.titulo);
            Console.WriteLine("Duración: {0}", cancionMP3.duracion);
            Console.WriteLine("Tamaño: {0}", cancionMP3.tam);
        }
    }
}
