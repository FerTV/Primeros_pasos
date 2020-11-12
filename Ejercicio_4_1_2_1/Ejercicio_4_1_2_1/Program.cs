using System;
using System.Diagnostics;

namespace Ejercicio_4_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dias_por_mes = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            int mes;

            Console.Write("Introduce un mes del año 1=enero, 12=diciembre: ");
            mes = Convert.ToInt32(Console.ReadLine());
            mes--;

            try
            {
                Console.WriteLine("El mes tiene {0} dias.", dias_por_mes[mes]);
            }
            catch(Exception)
            {
                Console.Write("Mes desconocido.");
            }
        }
    }
}
