using System;

namespace repaso_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_puertas, superficie, ancho, alto, num_ventanas;

            Console.Write("¿Cuántas puertas quieres introducir? ");
            num_puertas = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Cuántas ventanas quieres introducir? ");
            num_ventanas = Convert.ToInt32(Console.ReadLine());

            Tamanyo[] tam = new Tamanyo[num_puertas];

            for (int i = 0; i < tam.Length; i++)
            {
                Console.WriteLine("Introduce la puerta {0}", i + 1);

                Console.Write("Introduce el ancho: ");
                ancho = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce el alto: ");
                alto = Convert.ToInt32(Console.ReadLine());

                tam[i] = new Tamanyo(ancho, alto);
            }

            Tamanyo[] tamanyo_ventanas = new Tamanyo[num_ventanas];

            for(int i = 0; i<tamanyo_ventanas.Length; i++)
            {
                Console.WriteLine("Introduce la ventana {0}", i + 1);

                Console.Write("Introduce el ancho: ");
                ancho = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce el alto: ");
                alto = Convert.ToInt32(Console.ReadLine());

                tamanyo_ventanas[i] = new Tamanyo(ancho, alto);
            }

            Console.Write("Introduce la superfície del piso: ");
            superficie = Convert.ToInt32(Console.ReadLine());

            Piso piso = new Piso(superficie, tam, PuertaColor.blanco, tamanyo_ventanas, VentanaCalidad.aluminio);

            Console.WriteLine("El piso tiene una superfície de {0} y es: ", piso.superficie);

            for (int i = 0; i < piso.puerta.Length; i++)
            {
                Console.WriteLine("La puerta {0} tiene este ancho: {1} y este alto: {2}, su color: {3}.", i + 1, piso.puerta[i].ancho, piso.puerta[i].alto, piso.puerta[i].GetColor);
            }

            Console.WriteLine("--------------------------------------------------------------------");

            for (int i=0; i < piso.ventana.Length; i++)
            {
                Console.WriteLine("La ventana {0} tiene {1}x{2} y es de tipo {3}", i + 1, piso.ventana[i].ancho, piso.ventana[i].alto, piso.ventana[i].GetCalidad);
            }
        }
    }
}
