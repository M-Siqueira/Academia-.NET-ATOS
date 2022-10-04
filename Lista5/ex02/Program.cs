namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 3,somaLinha = 0,somaColuna = 0,aux, aux2,i,j; 

            int[,] mat = new int[t, t];

            for( i = 0; i < t; i++)
            {
                for( j = 0; j < t; j++)
                {
                    Console.WriteLine("inserir o valor de L: ["+i+"] C:["+j+"] ");
                    mat[i,j] = int.Parse(Console.ReadLine());

                    somaLinha += mat[i,j];

                    somaColuna += mat[i,j];

                }
            }

            for (i = 0; i < t; i++)
            {
                for (j = 0; j < t; j++)
                {
                    somaLinha += mat[i, j];

                }
            }

            for (j = 0; j < t; j++)
            {
                for (i = 0; i < t; i++)
                {
                    somaColuna += mat[i, j];

                }
            }
            Console.WriteLine(":"+somaLinha);
            Console.WriteLine(":"+somaColuna);


        }
    }
}