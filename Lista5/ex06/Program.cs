using System;

namespace ex06
{
    internal class Program
    {

        //        6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
        //Random random = new Random();
        //        int randomNumber = random.Next(0, 100);

        static void Main(string[] args)
        {
            int t = 4, maior = 0;
            int[,] M = new int[t, t];

            Random gerador = new Random();

            for(int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i,j] = gerador.Next(0,9);

                }
            }


            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write("["+M[i,j]+"] ");
                }
                Console.WriteLine("\n");
            }

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {

                    if (M[i,j] > maior)
                    {
                        maior = M[i,j];
                    }

                }
                
            }
            Console.WriteLine("o maior numero é: "+ maior);
        }
    }
}