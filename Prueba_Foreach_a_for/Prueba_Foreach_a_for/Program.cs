using System;

namespace Prueba_Foreach_a_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] diasMes = {31,28,21};

            foreach (int dias in diasMes)
            {
                Console.WriteLine("Dias del mes: {0}", dias);
            }

            for (int i=0;i<diasMes.Length;i++)
            {
                Console.WriteLine("(Dias del mes: {0}", diasMes[i]);
            }

            //----------------------------------
            string[] nombres = { "Alberto", "Andrés", "Antonio" };

            foreach (string nombre in nombres)
            {
                Console.Write(" {0}", nombre);
            }

            for (int i=0;i<nombres.Length;i++)
            {
                Console.Write(" {0}", nombres[i]);
            }

            Console.WriteLine();

            //----------------------------------
            string saludo = "Hola";

            foreach (char letra in saludo)
            {
                Console.Write("{0}-", letra);
            }

            for (int i=0;i<saludo.Length;i++)
            {
                Console.Write("{0}-", saludo[i]);
            }

            //Para ordenar un vector o información se puede arupar todo en una tabla de una base de 
            //datos y ordenarlo de esta manera
        }
    }
}
