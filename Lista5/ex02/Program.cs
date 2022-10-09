namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            2) Solicite ao usuário, preencher uma Matriz 3x3

            //Informe ao usuário:
            //*A soma dos elementos de cada linha

            //    -Ex: Linha 1: 30

            //         Linha 2: 17
            //* A soma dos elementos de cada coluna

            //    -Ex: Coluna 1: 23

            //         Coluna 2: 36

            int t = 3, somaColuna, i, j;

            int[,] mat = new int[t, t];

            int[] m1 = new int[t];

            for (i = 0; i < t; i++)
            {
                for (j = 0; j < t; j++)
                {
                    Console.WriteLine("inserir o valor de L: [" + i + "] C:[" + j + "] ");
                    mat[i, j] = int.Parse(Console.ReadLine());

                }
            }

            for (i = 0; i < t; i++)
            {
                for (j = 0; j < t; j++)
                {

                    m1[i] += mat[i, j];
                }


                Console.WriteLine("somada linha: " + m1[i]);

            }
            Console.WriteLine("\n");

            for (j = 0; j < t; j++)
            {
                somaColuna = 0;

                for (i = 0; i < t; i++)
                {
                    somaColuna += mat[i, j];
                }
                m1[j] = somaColuna;
                Console.WriteLine("somada coluna: " + m1[j]);
            }

            Console.WriteLine("\n");
            // Console.WriteLine(":"+somaLinha);
            //Console.WriteLine(":"+somaColuna);


        }
    }
}