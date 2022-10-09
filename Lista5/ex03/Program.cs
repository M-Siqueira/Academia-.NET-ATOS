using System.Reflection;

namespace ex03
{
    internal class Program
    {

        //3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!


        static void Main(string[] args)
        {
            int t = 4;
            int[,] mat = new int[t, t];

            for(int i = 0; i < t; i++)
            {
                for(int j = 0; j < t; j++)
                {
                    Console.WriteLine("insira os valores da linha: ["+i+"] coluna: ["+j+"].");
                    mat[i,j] = int.Parse(Console.ReadLine());

                }
            }


            //diag principal
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    if (i == j )
                    {
                        Console.WriteLine("valor [" + mat[i,j]+"]");
                    }

                }
            }

        }
    }
}