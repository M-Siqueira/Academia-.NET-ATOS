using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
namespace ex07
{
    internal class Program
    {
        //7) Leia duas matrizes A e B com 3x3 elementos.
        //Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B. (c = a - b)


        static void Main(string[] args)
        {
            int t = 3;
            int[,] A = new int[t, t];

            int[,] B = new int[t, t];

            int[,] C = new int[t, t];

            for(int i = 0; i < t; i++)
            {
                for(int j = 0; j < t; j++)
                {
                    Console.WriteLine("valor da matriz 1:\n");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.WriteLine("valor da matriz 2:\n");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }
           
            Console.WriteLine("\n");
            Console.WriteLine("matriz resposta:");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                    Console.Write("[" + C[i,j]+"] ");
                }
                Console.WriteLine("\n");
            }






        }
    }
}