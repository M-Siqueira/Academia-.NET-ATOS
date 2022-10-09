using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

namespace ex08
{
    internal class Program
    {
        //8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

        static void Main(string[] args)
        {
            int t = 4,i,j;
            int[,] matriz = new int[t, t];
            //int[,] matrizReversa = new int[t, t];

            for (i = 0; i < t ; i++)
            {
                for(j = 0; j < t; j++)
                {
                    Console.WriteLine("valores da matriz:\n");

                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("matriz leitura inversa: ");
            for (i = t-1; i >=  0; i--)
            {
                
                for (j = t-1; j >= 0; j--)
                {
                    Console.Write("["+matriz[i,j]+"] ");
                }
                Console.WriteLine("\n");
            }

        }
    }
}