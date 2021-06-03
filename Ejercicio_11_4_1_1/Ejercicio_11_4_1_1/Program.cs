using System;
using System.IO;
using System.Collections;

namespace Ejercicio_11_4_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta, linea;
            int verlinea;
            ArrayList miLista = new ArrayList();

            Console.Write("Introduce el nombre del fichero a leer: ");
            ruta = Console.ReadLine();

            using(StreamReader fichero=new StreamReader(ruta))
            {
                linea = fichero.ReadLine();

                for (int i= 0;linea != null;i++)
                {

                    if (linea != null)
                        miLista.Add(linea);

                    linea = fichero.ReadLine();
                }
            }

            do
            {
                Console.Write("¿Qué linea quieres ver? ");
                verlinea = Convert.ToInt32(Console.ReadLine());

                if (verlinea != -1)
                    Console.WriteLine(miLista[verlinea + 1]);
            }
            while (verlinea != -1);
        }
    }
}
