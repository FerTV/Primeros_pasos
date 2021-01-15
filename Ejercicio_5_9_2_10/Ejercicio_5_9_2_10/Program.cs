using System;

namespace Ejercicio_5_9_2_10
{

    class Program
    {
        static void Main(string[] args)
        {
            const int XPANTALLA = 24;
            const int YPANTALLA = 79;
            const double XCENTRO = 12;
            const double YCENTRO = 40;
            char[,] pantalla = new char[XPANTALLA, YPANTALLA];
            int coord_x, coord_y;

            //Calcular circulo
            for (int angulo = 0; angulo < 360; angulo++)
            {
                coord_x = (int)(XCENTRO + (XPANTALLA/4) * Math.Cos(angulo * (Math.PI / 180)));
                coord_y = (int)(YCENTRO + (XPANTALLA/4) * Math.Sin(angulo * (Math.PI / 180)));

                pantalla[coord_x, coord_y] = '*';
            }

            //Dibujar circulo
            for (int i = 0; i < XPANTALLA; i++)
            {
                for (int j = 0; j < YPANTALLA; j++)
                {
                    if (pantalla[i, j] == '*')
                    {
                        Console.Write('*');
                    }
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }

        }
    }
}
