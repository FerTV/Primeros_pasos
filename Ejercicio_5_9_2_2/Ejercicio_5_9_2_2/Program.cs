using System;

namespace Ejercicio_5_9_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, raiz, orden, temporal;

            do
            {
                do
                {
                    try
                    {
                        Console.Write("Introduce un número: ");
                        numero = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Introduce un orden: ");
                        orden = Convert.ToInt32(Console.ReadLine());
                        if (numero < 0|| orden<0)
                            throw new Exception();
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("El número no puede ser negativo");
                    }
                } while (true);

                if (numero != 0)
                {
                    temporal = 1 / orden;
                    raiz = Math.Pow(numero,temporal);
                    Console.WriteLine("La raíz de orden {0} de numero es: {1}", orden, raiz);
                }

            } while (numero != 0);
        }
    }
}
