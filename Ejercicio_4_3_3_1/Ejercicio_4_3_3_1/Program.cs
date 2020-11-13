using System;

namespace Ejercicio_4_3_3_1
{
    class Program
    {
        struct TipoDuracion
        {
            public int minutos;
            public int segundos;
        }
        struct TipoCancion
        {
            public string artista;
            public string titulo;
            public TipoDuracion duracion;
            public int tam;
        }
        static void Main(string[] args)
        {
            TipoCancion[] cancionMP3 = new TipoCancion[100];
            int cantidad = 0;
            char opcion;
            string buscar_cancion;
            bool cancion_encontrada = false;

            do
            {

                Console.WriteLine("¿Que quieres hacer?");
                Console.WriteLine("1. Añadir una nueva canción.");
                Console.WriteLine("2. Mostrar el título de todas las canciones");
                Console.WriteLine("3. Buscar canción");
                Console.WriteLine("4. Salir\n");
                Console.Write("Introduce la opción: ");
                opcion = Convert.ToChar(Console.ReadLine());

                switch (opcion)
                {
                    case '1':
                        Console.Write("Introduce el Artista: ");
                        cancionMP3[cantidad].artista = Convert.ToString(Console.ReadLine());
                        Console.Write("Introduce el título: ");
                        cancionMP3[cantidad].titulo = Convert.ToString(Console.ReadLine());
                        Console.Write("Introduce la duracion:\n Minutos: ");
                        cancionMP3[cantidad].duracion.minutos = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce los segundos: ");
                        cancionMP3[cantidad].duracion.segundos = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el tamaño en KB: ");
                        cancionMP3[cantidad].tam = Convert.ToInt32(Console.ReadLine());

                        cantidad++;
                        break;
                    case '2':
                        Console.WriteLine("Los títulos de las canciones introducidas son: ");
                        for (int i = 0; i < cantidad && i < 100; i++)
                        {
                            Console.WriteLine("{0}. {1}", i + 1, cancionMP3[i].titulo);
                        }
                        break;
                    case '3':
                        Console.Write("Introduce el titulo de la cancion o el artista de la cancion a buscar: ");
                        buscar_cancion = Convert.ToString(Console.ReadLine());

                        for (int i = 0; i < cantidad && i < 100; i++)
                        {
                            if (cancionMP3[i].titulo == buscar_cancion || cancionMP3[i].artista == buscar_cancion)
                            {
                                Console.WriteLine("Artista: {0}", cancionMP3[i].artista);
                                Console.WriteLine("Título: {0}", cancionMP3[i].titulo);
                                Console.WriteLine("Duración: minutos {0}, segundos {1}", cancionMP3[i].duracion.minutos, cancionMP3[i].duracion.segundos);
                                Console.WriteLine("Tamaño: {0}", cancionMP3[i].tam);
                                cancion_encontrada = true;
                                break;
                            }
                        }

                        if (cancion_encontrada == false)
                        {
                            Console.WriteLine("La canción no ha sido encontrada.");
                        }
                        else
                        {
                            cancion_encontrada = false;
                        }
                        break;
                    case '4':
                        break;
                    default:
                        Console.WriteLine("La opción introducida es incorrecta.");
                        break;
                }
            } while (opcion != '4');
        }
    }
}
