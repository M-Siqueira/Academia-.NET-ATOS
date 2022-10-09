namespace ex14
{
    internal class Program
    {

        //14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal(da esquerda para a direita)
        //são os mesmos da diagonal
        //secundária(direita pra esquerda).
        static void Main(string[] args)
        {
            int t = 3;
            int[,] matriz = new int[t, t];
            int soma = 0, soma2 = 0;

            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.WriteLine("informe linha [" + i + "] coluna [" + j + "]");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.Write("[" + matriz[i, j] + "] ");

                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n");
            Console.WriteLine("diagonal principal, esquerda/direita");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    if (i == j)
                    {
                        soma += matriz[i, j];
                        Console.Write("[" + matriz[i, j] + "] ");
                    }

                }

            }
            Console.WriteLine("soma da diagonal principal: " + soma);

            Console.WriteLine("\n");
            Console.WriteLine("diagonal secundaria:");

            for (int i = t - 1; i >= 0; i--)
            {
                Console.Write("[" + matriz[i, (t - 1) - i] + "] ");
                soma2 += matriz[i, (t - 1) - i];
            }
            Console.WriteLine("soma da diagonal secundaria: " + soma2);

            Console.WriteLine("\n");
            if (soma == soma2)
            {
                Console.WriteLine("somas das diagonais iguais.");

            }
            else
            {
                Console.WriteLine("somas das diagonais diferentes.");
            }
        }
    }
}