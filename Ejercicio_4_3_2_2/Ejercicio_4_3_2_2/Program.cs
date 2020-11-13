using System;
using System.Linq;

namespace Ejercicio_4_3_2_2
{
    class Program
    {
        struct TipoImagen
        {
            public string nombre;
            public int ancho;
            public int alto;
            public float tam;
        }
        static void Main(string[] args)
        {
            TipoImagen[] Imagen = new TipoImagen[700];
            int cantidad = 0;
            char opcion;
            int numero_buscar;
            string nombre_buscar;
            bool imagen_encontrada = false;

            do
            {
                Console.WriteLine("¿Qué quieres hacer?");
                Console.WriteLine("1. Añadir una nueva imagen");
                Console.WriteLine("2. Ver todas las imagenes");
                Console.WriteLine("3. Buscar una imagen");
                Console.WriteLine("4. Salir");
                Console.Write("Escoge la opcion: ");
                opcion = Convert.ToChar(Console.ReadLine());

                switch (opcion)
                {
                    case '1':
                        Console.Write("Introduce el nombre de la imagen: ");
                        Imagen[cantidad].nombre = Convert.ToString(Console.ReadLine());
                        Console.Write("Introduce el ancho de la imagen: ");
                        Imagen[cantidad].ancho = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el alto: ");
                        Imagen[cantidad].alto = Convert.ToInt32(Console.ReadLine());
                        Console.Write("introduce el tamaño: ");
                        Imagen[cantidad].tam = Convert.ToSingle(Console.ReadLine());

                        cantidad++;
                        if (cantidad == 699)
                            Console.WriteLine("No se pueden introducir más canciones, se ha llegado a la máxima capacidad.");
                        break;
                    case '2':
                        for (int i = 0; i < cantidad && i < 700; i++)
                        {
                            Console.WriteLine("Imagen {0}: ", i + 1);
                            Console.WriteLine("Nombre: {0}", Imagen[i].nombre);
                            Console.WriteLine("Ancho: {0}", Imagen[i].ancho);
                            Console.WriteLine("Alto: {0}", Imagen[i].alto);
                            Console.WriteLine("Tamaño: {0}\n", Imagen[i].tam);
                        }
                        break;
                    case '3':
                        Console.Write("Introduce el número de la imagen a buscar: ");
                        numero_buscar = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Introduce el nombre de la imagen a buscar: ");
                        nombre_buscar = Convert.ToString(Console.ReadLine());

                        for (int i = 0; i < cantidad && i < 700; i++)
                        {
                            if ((i + 1) == numero_buscar || nombre_buscar == Imagen[i].nombre)
                            {
                                Console.WriteLine("Imagen {0}", i + 1);
                                Console.WriteLine("Nombre: {0}", Imagen[i].nombre);
                                Console.WriteLine("Ancho: {0}", Imagen[i].ancho);
                                Console.WriteLine("Alto: {0}", Imagen[i].alto);
                                Console.WriteLine("Tamaño: {0}", Imagen[i].tam);
                                imagen_encontrada = true;
                                break;
                            }                          
                        }
                        if (imagen_encontrada == false)
                            Console.WriteLine("La imagen no se ha encontrado");
                        else
                            imagen_encontrada = false;
                        break;
                    case '4':
                        break;
                    default:
                        Console.WriteLine("La opción introducida no es válida");
                        break;
                }
            } while (opcion != '4');
        }
    }
}
