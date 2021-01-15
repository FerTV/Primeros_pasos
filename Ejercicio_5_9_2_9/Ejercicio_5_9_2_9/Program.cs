using System;

namespace Ejercicio_5_9_2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] pantalla = new char[21,73];
            double valor;

            //calcular valores funcion
            for (int coord_x = 0; coord_x < 73; coord_x++)
            {
                valor = (10 * Math.Sin(5 * coord_x * (Math.PI / 180)))+10;

                    pantalla[(int)valor, coord_x] = '*';
            }


            for(int coord_y=0;coord_y<21;coord_y++)
            {
                for(int coord_x=0;coord_x<73;coord_x++)
                {
                    if (pantalla[coord_y, coord_x] == '*')
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
