using System;
using System.IO;
public class Ejercicio_8_6_2
{
    public static void Main()
    {
        StreamReader fichero;
        string nombre;
        bool parar=false;

        while (parar) // Interrumpimos desde dentro con "break"
        {
            Console.Write("Nombre del fichero (\"fin\" para terminar)? ");
            nombre = Console.ReadLine();
            if (nombre == "fin")
            {
                parar = true;
                break;
            }
            if (File.Exists(nombre))
            {
                fichero = File.OpenText(nombre);
                Console.WriteLine("Su primera linea es: {0}",
                fichero.ReadLine());
                fichero.Close();
            }
            else
                Console.WriteLine("No existe!");
        }
    }
}
