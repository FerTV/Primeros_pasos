using System;

namespace Ejercicio_6_2_2
{
    class Program
    {
        public class Juego
        {
            public void lanzar()
            {
                Console.WriteLine("Bienvenido a Console Invaders. Pulse Intro para salir.");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Juego juego1 = new Juego();

            juego1.lanzar();
        }
    }
}
