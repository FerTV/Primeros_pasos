using System;

namespace Ejercicio_5_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0, n1, n2;

            if(args.Length>=3)
            {
                n1 = Convert.ToInt32(args[0]);
                n2 = Convert.ToInt32(args[2]);

                switch(args[1])
                {
                    case "+":
                        resultado = n1 + n2;
                        break;
                    case "-":
                        resultado = n1 - n2;
                        break;
                    case "*":
                        resultado = n1 * n2;
                        break;
                    case "/":
                        if (args[2] != "0")
                        {
                             resultado = n1 / n2;
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre 0");
                        }
                            break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                Console.WriteLine("El resultado es: {0}", resultado);
            }
            else
            {
                Console.WriteLine("Error no hay suficientes argumentos");
            }
        }
    }
}
