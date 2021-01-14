using System;

namespace Ejercicio_5_9_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, raiz;

            do
            {
                do
                {
                    try
                    {
                        Console.Write("Introduce un número: ");
                        numero = Convert.ToDouble(Console.ReadLine());
                        if (numero < 0)
                            throw new Exception();
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("El número no puede ser negativo");
                    }
                } while (true);

                raiz = Math.Sqrt(numero);

                if (numero != 0)
                    Console.WriteLine("La raíz cuadrada del número es: {0}", raiz);

            } while (numero != 0);
        }
    }
}
