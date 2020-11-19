using System;

namespace Ejercicio_prueba_eliminar_palabras
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string palabra_eliminar;
            string palabra_introducir;
            int posicion;
            
            Console.Write("Introduce la frase: ");  
            frase = Console.ReadLine();
            Console.Write("Introduce la palabra a eliminar: ");
            palabra_eliminar = Console.ReadLine();
            Console.Write("Introduce la palabra a introducir: ");
            palabra_introducir = Console.ReadLine();

            posicion = frase.ToUpper().IndexOf(palabra_eliminar.ToUpper());

            while (posicion != -1)
            {
                frase = frase.Remove(posicion, palabra_eliminar.Length);
                frase = frase.Insert(posicion, palabra_introducir);
                posicion = frase.ToUpper().IndexOf(palabra_eliminar.ToUpper());
            }

            Console.WriteLine("La frase resultante es: {0}", frase);
        }
    }
}
