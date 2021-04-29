﻿using System;
using System.IO;
public class Ejemplo_04_06a
{
    static int numeroFichas = 0; // Número de fichas que ya tenemos
    public struct tipoFicha
    {
        public string nombreFich; // Nombre del fichero
        public long tamanyo; // El tamaño en KB
    };

    public static void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Escoja una opción:");
        Console.WriteLine("1.- Añadir datos de un nuevo fichero");
        Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
        Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño");
        Console.WriteLine("4.- Ver datos de un fichero");
        Console.WriteLine("5.- Salir");
    }
    public static void AnadirDatoFichero(int numeroFichas, tipoFicha[] fichas)
    {
        if (numeroFichas < 1000)
        { // Si queda hueco
            Console.WriteLine("Introduce el nombre del fichero: ");
            fichas[numeroFichas].nombreFich = Console.ReadLine();
            Console.WriteLine("Introduce el tamaño en KB: ");
            fichas[numeroFichas].tamanyo = Convert.ToInt32(
            Console.ReadLine());
            // Y ya tenemos una ficha más
            numeroFichas++;
        }
        else // Si no hay hueco para más fichas, avisamos
            Console.WriteLine("Máximo de fichas alcanzado (1000)!");
    }
    public static void MostrarDatos(int numeroFichas, tipoFicha[] fichas)
    {
        for (int i = 0; i < numeroFichas; i++)
            Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
            fichas[i].nombreFich, fichas[i].tamanyo);
    }
    public static void MostrarDatosSegunTam(int numeroFichas, tipoFicha[] fichas)
    {
        long tamanyoBuscar;

        Console.WriteLine("¿A partir de que tamaño quieres ver?");
        tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
        for (int i = 0; i < numeroFichas; i++)
            if (fichas[i].tamanyo >= tamanyoBuscar)
                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                fichas[i].nombreFich, fichas[i].tamanyo);
    }
    public static void VerDatosFichero(int numeroFichas, tipoFicha[] fichas)
    {
        string textoBuscar;

        Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
        textoBuscar = Console.ReadLine();
        for (int i = 0; i < numeroFichas; i++)
            if (fichas[i].nombreFich == textoBuscar)
                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                fichas[i].nombreFich, fichas[i].tamanyo);
    }

    public static void Guardar(int numeroFichas, tipoFicha[] fichas)
    {
        StreamWriter fichero;

        using (fichero = new StreamWriter("basededatos.txt"))
        {
            fichero.WriteLine("[");

            for (int i = 0; i < numeroFichas; i++)
            {
                fichero.WriteLine("\t{");
                fichero.WriteLine("\t\tNombre: {0}, \n\t\tTamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
                fichero.WriteLine("\t},");
            }

            fichero.WriteLine("]");
        }
    }
    public static void Main()
    {
        tipoFicha[] fichas = new tipoFicha[1000];
        int opcion; // La opcion del menu que elija el usuario

        do
        {

            // Menu principal, repetitivo
            MostrarMenu();
            opcion = Convert.ToInt32(Console.ReadLine());
            // Hacemos una cosa u otra según la opción escogida
            switch (opcion)
            {

                case 1: // Añadir un dato nuevo
                    AnadirDatoFichero(numeroFichas, fichas);
                    break;

                case 2: // Mostrar todos
                    MostrarDatos(numeroFichas, fichas);
                    break;

                case 3: // Mostrar según el tamaño
                    MostrarDatosSegunTam(numeroFichas, fichas);
                    break;

                case 4: // Ver todos los datos (pocos) de un fichero
                    VerDatosFichero(numeroFichas, fichas);
                    break;

                case 5: // Salir: avisamos de que salimos */
                    Console.WriteLine("Fin del programa");
                    Guardar(numeroFichas, fichas);
                    break;

                default: // Otra opcion: no válida
                    Console.WriteLine("Opción desconocida!");
                    break;
            }
        } while (opcion != 5); // Si la opcion es 5, terminamos
    }
}