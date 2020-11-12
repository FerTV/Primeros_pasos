using System;
using System.Linq;

namespace Ejercicio_4_3_2_2
{
    class Program
    {
        struct tipoImagen
        {
            public string nombre;
            public int ancho;
            public int alto;
            public float tam;
        }
        static void Main(string[] args)
        {
            tipoImagen[] Imagen = new tipoImagen[700];
            int cantidad = 0;
            char opcion;

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
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    default:
                        break;
                }
            } while (opcion != '4');
        }
    }
}
