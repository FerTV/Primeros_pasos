using System;
using System.Diagnostics;

namespace Ejercicio_4_1_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAPACIDAD = 10;
            string[] nombres = new string[CAPACIDAD];
            int cantidad = 0, posicion;
            char opcion;
            string nombre_a_introducir;

            do
            {
                Console.Write("Opciones: \n" +
                              "0. Salir del programa.\n" +
                              "1. Insertar dato al final de los ya existentes\n" +
                              "2. Insertar dato en una posición\n" +
                              "3. Borrar dato de una cierta posición\n" +
                              "4. Mostrar los datos que contiene el array.\n\n" +
                              "Introduce la opcion: ");
                opcion = Convert.ToChar(Console.ReadLine());

                switch (opcion)
                {
                   case '1':
                        Console.Write("¿Qué nombre quieres introducir? ");
                        nombre_a_introducir = Console.ReadLine();
                        if(cantidad<CAPACIDAD)
                        {
                            nombres[cantidad] = nombre_a_introducir;
                            cantidad++;
                        }
                        break;
                   case '2':
                        Console.Write("¿Que nombre quieres introducir? ");
                        nombre_a_introducir = Console.ReadLine();
                        Console.Write("¿En que posicion deseas introducirlo? ");
                        posicion = Convert.ToInt32(Console.ReadLine());
                        posicion--;

                        for (int i = cantidad; i > posicion; i--)
                        {
                            nombres[i] = nombres[i - 1];
                        }

                        nombres[posicion] = nombre_a_introducir;
                        cantidad++;
                        break;
                    case '3':
                        Console.Write("¿Que posicion quieres borrar? ");
                        posicion = Convert.ToInt32(Console.ReadLine());
                        posicion--;

                        for (int i = posicion; i < cantidad + 1; i++)
                        {
                            nombres[i] = nombres[i + 1];
                        }
                        cantidad--;
                        break;
                    case '4':
                        Console.WriteLine("Este es el vector: ");

                        Console.Write("[");
                        for(int i=0;i<CAPACIDAD;i++)
                        {
                            Console.Write("\"{0}\"", nombres[i]);
                            if (i < CAPACIDAD - 1)
                                Console.Write(", ");
                        }
                        Console.WriteLine("]");
                        break;
                    default:
                        break;
                }
            } while (opcion != '0');  
        }
    }
}
