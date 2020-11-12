using System;

namespace Ejercicio_4_1_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dias_por_mes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mes, dia, dia_anno=0;

            Console.Write("Introduce el mes del año 1=enero 12=diciembre: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el dia del mes: ");
            dia = Convert.ToInt32(Console.ReadLine());

            mes--;

            for(int i=0; i<=mes;i++)
            {
                dia_anno += dias_por_mes[i];
            }
            if (dia < dias_por_mes[mes])
                dia_anno += dia - dias_por_mes[mes];

            Console.WriteLine("El dia introducido es el dia {0} del año.", dia_anno);
        }
    }
}
