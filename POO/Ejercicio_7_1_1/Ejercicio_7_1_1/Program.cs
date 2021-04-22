using System;

namespace Ejercicio_7_1_1
{
    public class Hardware
    {
        public static void BorrarPantalla()
        {
            for (byte i = 0; i < 25; i++)
                Console.WriteLine();
        }
        public static void EscribirCentrado(string texto)
        {
            Console.SetCursorPosition((Console.WindowWidth - texto.Length) / 2, Console.CursorTop);
            Console.WriteLine(texto);
        }
    }
    public class Ejercicio_7_1_1
    {
        public static void Main()
        {
            string texto;

            Console.WriteLine("Pulsa Intro para borrar");
            Console.WriteLine("Texto a centrar: ");
            texto = Console.ReadLine();

            Hardware.EscribirCentrado(texto);
            //Hardware.BorrarPantalla();
            //Console.WriteLine("Borrado!");
        }
    }
}
