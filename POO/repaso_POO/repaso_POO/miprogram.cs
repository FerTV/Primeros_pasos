using System;

namespace repaso_POO
{
    class miprogram
    {
        static void main1()
        {
            int num_puertas, ancho, alto, num_ventanas=3;

            Console.Write("¿Cuántas puertas quieres introducir? ");
            num_puertas = Convert.ToInt32(Console.ReadLine());

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

            for (int i = 0; i < tamanyo_ventanas.Length; i++)
            {
                Console.WriteLine("Introduce la ventana {0}", i + 1);

                Console.Write("Introduce el ancho: ");
                ancho = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce el alto: ");
                alto = Convert.ToInt32(Console.ReadLine());

                tam[i] = new Tamanyo(ancho, alto);
            }

            Console.WriteLine("--------------------------------------------");

            Piso piso = new Piso(90, tam, PuertaColor.nogal, tamanyo_ventanas, VentanaCalidad.aluminio);

            for(int i=0; i < piso.puerta/*s*/.Length; i++)
            {
                Console.WriteLine("Piso 1 ({0} m2). Puerta{1} : {2}x{3}", piso.superficie, piso.puerta[i].ancho, piso.puerta[i].alto, piso.puerta[i].color)/*s.puerta[i]*/;
            }

            Console.WriteLine("---------------------------------------------------------------");

            Piso piso2 = new Piso(120, PuertaColor.nogal);

            for (int i = 0; i < piso.puerta/*s*/.Length; i++)
            {
                Console.WriteLine("Piso 2 ({0} m2). Puerta{1} : {2}x{3}", piso.superficie, piso.puerta[i].ancho, piso.puerta[i].alto, piso.puerta[i].color)/*s.puerta[i]*/;
            }  
        }
    }
}
