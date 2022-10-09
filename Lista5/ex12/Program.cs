using System.Runtime.Intrinsics.X86;

namespace ex12
{
    internal class Program
    {

        //12) Escreva um programa que leia os valores de uma matriz 4x3,
        //e em seguida mostre na tela apenas os valores cuja soma dos índices(i+j)
        //seja um número par.
        static void Main(string[] args)
        {
            int t1 = 4, t2 = 3;
            int[,] matriz = new int[t1, t2];

            for(int i = 0; i < t1; i++)
            {
                for(int j = 0; j < t2; j++)
                {
                    Console.WriteLine("digite um valor linha ["+i+ "]  coluna ["+j+"] ");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("\n");
            Console.WriteLine("matriz: ");

            for (int i = 0; i < t1; i++)
            {
                for (int j = 0; j < t2; j++)
                {
                    Console.Write("["+ matriz[i,j] +"] ");
                }
                Console.WriteLine("\n");
            }


            Console.WriteLine("\n");
            Console.WriteLine("matriz com soma de indices pares: ");

            for (int i = 0; i < t1; i++)
            {
                for (int j = 0; j < t2; j++)
                {
                    int aux = i + j;

                    if (aux % 2 == 0)
                    {
                        Console.Write("[" + matriz[i, j] + "] ");
                    }
                    
                }
                Console.WriteLine("\n");
            }
        }
    }
}