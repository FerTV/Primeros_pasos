using System;

namespace Ejercicio_4_4_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            string operacion;
            int resultado;

            Console.Write("Introduce el primer número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la operación a realizar: ");
            operacion = Console.ReadLine();

            switch(operacion)
            {
                case "suma":
                case "+":
                    resultado = n1 + n2;
                    Console.WriteLine("El resultado es: {0}", resultado);
                    break;
                case "resta":
                case "-":
                    resultado = n1 / n2;
                    Console.WriteLine("El resultado es: {0}", resultado);
                    break;
                case "multiplicación":
                case "x":
                case "X":
                    resultado = n1 * n2;
                    Console.WriteLine("El resultado es: {0}", resultado);
                    break;
                case "división":
                case "/":
                    resultado = n1 * n2;
                    Console.WriteLine("El resultado es: {0}", resultado);
                    break;
                default:
                    Console.WriteLine("La operación introducida no existe.");
                    break;
            }
        }
    }
}
