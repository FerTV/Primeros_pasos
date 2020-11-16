using System;

namespace Ejercicio_4_4_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena_numero1;
            string cadena_numero2;
            int n1;
            int n2;
            int resultado;
            string cadena_resultado="";
            int acarreo = 0;
            int suma;

            Console.Write("Introduce el primer número: ");
            cadena_numero1 = Console.ReadLine();

            Console.Write("Introduce el segundo número: ");
            cadena_numero2 = Console.ReadLine();

            for (int i = cadena_numero1.Length - 1; i >= 0; i--)
            {
                n1 = (int)Char.GetNumericValue(cadena_numero1[i]);
                n2 = (int)Char.GetNumericValue(cadena_numero2[i]);
                suma = n1 + n2;
                resultado = suma + acarreo;
                if (suma > 9)
                {
                    acarreo = 1;
                    resultado -= 10;
                }
                else
                    acarreo = 0;
                cadena_resultado += Convert.ToString(resultado);//almacena el resultado, pero los nuevos valores iran a la
                                                                //derecha en vez de a la izquierda por lo que habrá que leerla al revés
            }

            Console.Write("El resultado es: ");

            //Leo la cadena_resultado al reves
            for (int i = cadena_resultado.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}", cadena_resultado[i]);
            }
        }
    }
}
