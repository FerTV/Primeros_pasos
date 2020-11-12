using System;

namespace Ejercicio_3_2_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float v_ms = 0, v_kh=0,v_mh=0, distancia = 0;
            float horas = 0, minutos = 0, segundos = 0, segundos_totales=0, horas_totales=0;

            Console.Write("Introduce la distancia para calcular la velocidad: ");
            distancia = Convert.ToSingle(Console.ReadLine());

            Console.Write("Introduce las horas que tardas en recorrerla: ");
            horas = Convert.ToSingle(Console.ReadLine());

            Console.Write("Introduce los minutos que tardas en recorrerla: ");
            minutos = Convert.ToSingle(Console.ReadLine());

            Console.Write("Introduce los segundos que tardas en recorrela: ");
            segundos = Convert.ToSingle(Console.ReadLine());

            segundos_totales = segundos + (60 / minutos) + (3600 * horas);
            horas_totales = horas + (minutos / 60) + (segundos / 3600);

            v_ms = distancia / segundos_totales;
            v_kh = distancia / horas_totales;
            distancia = distancia / 1609;
            v_mh = distancia / horas_totales;

            Console.WriteLine("La velocidad en en m/s es {0}, en k/h es {1} y en millas/h es {2}.", v_ms, v_kh, v_mh);
        }
    }
}
