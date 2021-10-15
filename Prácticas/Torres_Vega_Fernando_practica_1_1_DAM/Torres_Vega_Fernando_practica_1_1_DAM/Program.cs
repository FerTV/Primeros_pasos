using System;

namespace Torres_Vega_Fernando_practica_1_1_DAM
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------------
            // Fernando Torres Vega
            // Curso DAM
            // Modalidad Presencial
            // Práctica nº 1
            // --------------------------------------------

            int numero = 0, resultado = 0;
            char operacion = ' ';

            do
            {
                //Comprobación e introducción de número 1
                if (operacion == ' ')
                {
                    do
                    {
                        try
                        {
                            Console.Write("Introduce un número: ");
                            resultado = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("--> Número incorrecto");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("--> Número incorrecto");
                        }
                    } while (true);
                }

                //Comprobación e introducción de operación
                do
                {
                    try
                    {
                        Console.Write("Introduce una operación: ");
                        operacion = Convert.ToChar(Console.ReadLine());

                        if ((operacion != '+') && (operacion != '-') && (operacion != '*')
                        && (operacion != '/') && (operacion != 's') && (operacion != '='))
                        {
                            throw new Exception("--> Operación incorrecta");
                        }

                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (true);

                //Comprobación e introducción de número a operar
                if (operacion != 's' && operacion != '=')
                {
                    do
                    {
                        try
                        {
                            Console.Write("Introduce un número: ");
                            numero = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("--> Número incorrecto");
                        }
                    } while (true);
                }

                //operaciones a realizar
                switch (operacion)
                {
                    case '+':
                        resultado += numero;
                        break;
                    case '-':
                        resultado -= numero;
                        break;
                    case '*':
                        resultado *= numero;
                        break;
                    case '/':
                        resultado /= numero;
                        break;
                    case '=':
                        Console.WriteLine("El resultado es {0}\n", resultado);
                        resultado = 0;
                        operacion = ' ';//Se reinicia la introducción del número 1
                        break;
                    default:
                        Console.Write("El resultado es {0}\n\nFIN DEL PROGRAMA", resultado);
                        break;
                }
            } while (operacion != 's');
        }
    }
}