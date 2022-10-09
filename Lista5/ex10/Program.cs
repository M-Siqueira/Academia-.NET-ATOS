using System.Globalization;
using System.Net;

namespace ex10
{
    internal class Program
    {
       // 10) Leia duas matrizes A e B de 4x4 elementos,
       // calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

        static void Main(string[] args)
        {
            int t = 2;
            double[,] A = new double[t, t];
            double[,] B = new double[t, t];

            double[,] media = new double[t,t];
            int acima = 0, abaixo = 0, naMedia = 0;

            for(int i = 0; i < t; i++)
            {
                for(int j = 0; j < t; j++)
                {
                    Console.WriteLine("valor:\n");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.WriteLine("valor:\n");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("medias");
            for (int i = 0; i < t; i++)
            {
                for(int j = 0; j < t; j++)
                {
                    media[i, j] = (A[i, j] + B[i, j]) / t;
                    Console.WriteLine(media[i,j]);
                }
            }

            Console.WriteLine("abaixo ou acima da media");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    if(A[i, j] > media[i, j])
                    {
                        acima++;
                        Console.WriteLine(A[i, j] + " da lista A, esta  acima da media.\n");
                    }
                    if (B[i, j] > media[i, j])
                    {
                        abaixo++;
                        Console.WriteLine(B[i, j] + " da lista B, esta  acima da media.\n");
                    }
                    if (A[i,j] == media[i,j])
                    {
                        naMedia++;
                    }
                }
            }

            Console.WriteLine(acima+ " acima da media");
            Console.WriteLine(abaixo + " abaixo da media");
            Console.WriteLine(naMedia + " na media");





        }
    }
}