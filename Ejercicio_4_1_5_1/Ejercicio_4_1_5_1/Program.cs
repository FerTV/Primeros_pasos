using System;

namespace Ejercicio_4_1_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM_MESES = 11;
            string[] meses = {"Enero","Febrero","Marzo","Abril","Mayo",
                              "Junio","Julio","Agosto","Septiembre",
                              "Octubre","Noviembre","Diciembre"};
            char respuesta;

            Console.Write("¿Quieres ver los meses de forma naturaL? (y/n)");
            respuesta = Convert.ToChar(Console.ReadLine());

            Console.Write("Los meses son: ");

            if (respuesta == 'y')
            {
                for (int i = 0; i <= NUM_MESES; i++)
                {
                    Console.Write("{0} ", meses[i]);
                }
            }
            else
            {
                for (int i = NUM_MESES; i >= 0; i--)
                {
                    Console.Write("{0} ", meses[i]);
                }
            }
        }

    }
}
