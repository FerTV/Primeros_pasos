using System;

namespace Ejercicio_5_5_3
{
    class Program
    {
        public static bool EsPrimo(int numero)
        {
            bool es_primo = true;

            for(int i=2; i<numero;i++)
            {
                if (numero % i == 0)
                {
                    es_primo = false;
                    return es_primo;
                }
            }
            return es_primo;
        }
        static void Main(string[] args)
        {
            int numero;
            bool ser_primo;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            ser_primo = EsPrimo(numero);

            if (ser_primo == true)
                Console.WriteLine("El número es primo");
            else
                Console.WriteLine("EL número no es primo");
        }
    }
}
