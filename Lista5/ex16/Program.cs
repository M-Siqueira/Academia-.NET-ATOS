namespace ex16
{
    internal class Program
    {

        //16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.
        //Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.
        static void Main(string[] args)
        {
            int t1 = 3, t2 = 4, conta = 0,conta2 = 0;
            int[,] mat = new int[t1, t2];
            int[] auxT = new int[t1 * t2];
            int[,] matT = new int[t2, t1];

            for (int i = 0; i < t1; i++)
            {
                for (int j = 0; j < t2; j++)
                {
                    Console.WriteLine("digite os itens da matriz: ");
                    mat[i, j] = int.Parse(Console.ReadLine());

                    auxT[conta] = mat[i, j];
                    conta++;
                }
            }



            Console.WriteLine("matriz 3x4");

            for (int i = 0; i < t1; i++)
            {
                for (int j = 0; j < t2; j++)
                {
                    Console.Write("[" + mat[i, j] + "] ");
                }
                Console.WriteLine("\n");
            }




            Console.WriteLine("matriz 4x3"); // em andamento

            for (int j = 0; j < t1; j++)
            {
                for (int i = 0; i < t2; i++)
                {
                    matT[j, i] = auxT[conta2];

                    Console.Write("["+matT[j, i]+"] "); 
                }
                Console.WriteLine("\n");
                conta2++;
            }



            






        }
    }
}