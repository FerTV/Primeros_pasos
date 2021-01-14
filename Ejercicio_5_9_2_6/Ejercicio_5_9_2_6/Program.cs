using System;

namespace Ejercicio_5_9_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double coord_x_p1, coord_y_p1, coord_x_p2, coord_y_p2, distancia;

            Console.Write("Introduce x1: ");
            coord_x_p1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce y1: ");
            coord_y_p1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce x2: ");
            coord_x_p2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce y2: ");
            coord_y_p2 = Convert.ToInt32(Console.ReadLine());

            distancia = Math.Sqrt(Math.Pow((coord_x_p1 - coord_x_p2), 2) + Math.Pow((coord_y_p1 - coord_y_p2), 2));
            Console.WriteLine("La distancia es: {0}", distancia);
        }
    }
}
