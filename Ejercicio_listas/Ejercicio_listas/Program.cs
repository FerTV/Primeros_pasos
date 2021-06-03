using System;
using System.Collections;

namespace Ejercicio_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList miLista = new ArrayList();
            
            miLista.Add("Hola,");
            miLista.Add("soy");
            miLista.Add("yo");
            
            Console.WriteLine("Contenido actual:");
            foreach (string frase in miLista)
                Console.WriteLine(frase);
            
            Console.WriteLine("La segunda palabra es: {0}",
            miLista[1]);
            
            miLista.Insert(1, "Como estas?");
            
            Console.WriteLine("Contenido tras insertar:");
            for (int i = 0; i < miLista.Count; i++)
                Console.WriteLine(miLista[i]);
            
            Console.WriteLine("La palabra \"yo\" está en la posición {0}",
            miLista.IndexOf("yo"));
            
            miLista.Sort();
            
            Console.WriteLine("Contenido tras ordenar");
            foreach (string frase in miLista)
                Console.WriteLine(frase);
            
            Console.WriteLine("Ahora \"yo\" está en la posición {0}",
            miLista.BinarySearch("yo"));
            
            miLista.Reverse();
            
            miLista.RemoveAt(1);
            miLista.Remove("yo");
            
            Console.WriteLine("Contenido dar la vuelta y tras eliminar dos:");
            foreach (string frase in miLista)
                Console.WriteLine(frase);
            
            miLista.Sort();
            Console.WriteLine("La frase \"Hasta Luego\"...");
            int posicion = miLista.BinarySearch("Hasta Luego");
            if (posicion >= 0)
                Console.WriteLine("Está en la posición {0}", posicion);
            else
                Console.WriteLine("No está. El dato inmediatamente mayor " +
                "es el {0}: {1}",
                ~posicion, miLista[~posicion]);
        }
    }
}
