namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice,
            //colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

            int t = 4;
            int[] valoresA = new int[t];
            int[] valoresB = new int[t];
            int i;

            int[] resposta = new int[t];






            for (i = 0; i < t; i++)
            {
                Console.WriteLine("digite o valor d A na posição " + (i + 1));
                valoresA[i] = int.Parse(Console.ReadLine());

            }

            for (i = 0; i < t; i++)
            {
                Console.WriteLine("digite o valor de B na posição " + (i + 1));
                valoresB[i] = int.Parse(Console.ReadLine());

            }


            for (i = 0; i < t; i++)
            {
                resposta[i] = valoresA[i] * valoresB[i];

                Console.WriteLine("a multiplicação dos valores em  A x B:" + resposta[i]);
            }


        }
    }
}