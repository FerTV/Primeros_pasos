using System;

namespace Ejercicio_2_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, producto=1;

            Console.Write("Introduce un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 == 0)
                Console.WriteLine("El producto de 0 por cualquier número es 0.");
            else
            {
                Console.Write("Introduce otro número: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                producto = n1 * n2;
                Console.WriteLine("El producto de los números introducidos es: {0}", producto);
            }

        }
    }
}
