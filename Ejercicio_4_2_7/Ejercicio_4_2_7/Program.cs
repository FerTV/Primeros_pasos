using System;

namespace Ejercicio_4_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduce la ecuación {0}: ", i + 1);
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Introduce el número {0} de la ecuación: ", j + 1);
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //-g*(d,e,f,k)=s1
            matriz[1, 0] = -matriz[2, 0] * matriz[1, 0];
            matriz[1, 1] = -matriz[2, 0] * matriz[1, 1];
            matriz[1, 2] = -matriz[2, 0] * matriz[1, 2];
            matriz[1, 3] = -matriz[2, 0] * matriz[1, 3];
            //d*(g,h,i,l)=s2
            matriz[2, 0] = matriz[1, 0] * matriz[2, 0];
            matriz[2, 1] = matriz[1, 0] * matriz[2, 1];
            matriz[2, 2] = matriz[1, 0] * matriz[2, 2];
            matriz[2, 3] = matriz[1, 0] * matriz[2, 3];
            //(g,h,i,l)=s1+s2
            matriz[2, 0] = matriz[1, 0] + matriz[2, 0];
            matriz[2, 1] = matriz[1, 1] + matriz[2, 1];
            matriz[2, 2] = matriz[1, 2] + matriz[2, 2];
            matriz[2, 3] = matriz[1, 3] + matriz[2, 3];

            //-d*(a,b,c,j)=s3
            matriz[0, 0] = -matriz[1, 0] * matriz[0, 0];
            matriz[0, 1] = -matriz[1, 0] * matriz[0, 1];
            matriz[0, 2] = -matriz[1, 0] * matriz[0, 2];
            matriz[0, 3] = -matriz[1, 0] * matriz[0, 3];
            //a*(d,e,f,k)=s4
            matriz[1, 0] = matriz[0, 0] * matriz[1, 0];
            matriz[1, 1] = matriz[0, 0] * matriz[1, 1];
            matriz[1, 2] = matriz[0, 0] * matriz[1, 2];
            matriz[1, 3] = matriz[0, 0] * matriz[1, 3];
            //(d,e,f,k)=s3+s4
            matriz[1, 0] = matriz[0, 0] + matriz[1, 0];
            matriz[1, 1] = matriz[0, 1] + matriz[1, 1];
            matriz[1, 2] = matriz[0, 2] + matriz[1, 2];
            matriz[1, 3] = matriz[0, 3] + matriz[1, 3];

            //-i*(d,e,f,k)=s5
            matriz[1, 0] = -matriz[2, 2] * matriz[1, 0];
            matriz[1, 1] = -matriz[2, 2] * matriz[1, 1];
            matriz[1, 2] = -matriz[2, 2] * matriz[1, 2];
            matriz[1, 3] = -matriz[2, 2] * matriz[1, 3];
            //f*(g,h,i,l)=s6
            matriz[2, 0] = matriz[1, 2] * matriz[2, 0];
            matriz[2, 1] = matriz[1, 2] * matriz[2, 1];
            matriz[2, 2] = matriz[1, 2] * matriz[2, 2];
            matriz[2, 3] = matriz[1, 2] * matriz[2, 3];
            //(d,e,f,k)=s5+s6
            matriz[1, 0] = matriz[1, 0] + matriz[2, 0];
            matriz[1, 1] = matriz[1, 1] + matriz[2, 1];
            matriz[1, 2] = matriz[1, 2] + matriz[2, 2];
            matriz[1, 3] = matriz[1, 3] + matriz[2, 3];

            //-i*(a,b,c,j)=s7
            matriz[0, 0] = -matriz[2, 2] * matriz[0, 0];
            matriz[0, 1] = -matriz[2, 2] * matriz[0, 1];
            matriz[0, 2] = -matriz[2, 2] * matriz[0, 2];
            matriz[0, 3] = -matriz[2, 2] * matriz[0, 3];
            //c*(g,h,i,l)=s8
            matriz[2, 0] = -matriz[0, 3] * matriz[2, 0];
            matriz[2, 1] = -matriz[0, 3] * matriz[2, 1];
            matriz[2, 2] = -matriz[0, 3] * matriz[2, 2];
            matriz[2, 3] = -matriz[0, 3] * matriz[2, 3];
            //(a,b,c,j)=s7+s8
            matriz[0, 0] = matriz[0, 0] + matriz[2, 0];
            matriz[0, 1] = matriz[0, 1] + matriz[2, 1];
            matriz[0, 2] = matriz[0, 2] + matriz[2, 2];
            matriz[0, 3] = matriz[0, 3] + matriz[2, 3];

            //-h*(a,b,c,j)=s9
            matriz[0, 0] = -matriz[2, 1] * matriz[0, 0];
            matriz[0, 1] = -matriz[2, 1] * matriz[0, 1];
            matriz[0, 2] = -matriz[2, 1] * matriz[0, 2];
            matriz[0, 3] = -matriz[2, 1] * matriz[0, 3];
            //b*(g,h,i,l)=s10
            matriz[2, 0] = -matriz[0, 1] * matriz[2, 0];
            matriz[2, 1] = -matriz[0, 1] * matriz[2, 1];
            matriz[2, 2] = -matriz[0, 1] * matriz[2, 2];
            matriz[2, 3] = -matriz[0, 1] * matriz[2, 3];
            //(g,h,i,l)=s9+s10
            matriz[2, 0] = matriz[0, 0] + matriz[2, 0];
            matriz[2, 1] = matriz[0, 1] + matriz[2, 1];
            matriz[2, 2] = matriz[0, 2] + matriz[2, 2];
            matriz[2, 3] = matriz[0, 3] + matriz[2, 3];

            for(int i=0;i<3;i++)
            {
                for(int j=0;j<4;j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
