using System.Net;

namespace ex3
{
    internal class Program
    {       //3.	Escreva um algoritmo que leia os valores para um vetor de 20
            //elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.

        static void Main(string[] args)
        {
            int valor = 1, divisores = 0, t = 20;

            int[] elemento = new int[t];

            for (int j = 0; j < t; j++)
            {
                Console.WriteLine("digite o numero: \n");
                elemento[j] = int.Parse(Console.ReadLine());

                for (int i = 0; i < elemento[j]; i++)
                {
                    if (elemento[j] % valor == 0)
                    {
                        divisores++;
                        valor++;

                    }
                    if (elemento[j] % valor != 0)
                    {
                        valor++;
                    }
                }


            }
            for (int j = 0; j < t; j++)
            {
                if (divisores == 2)
                {

                    Console.WriteLine(elemento[j] + " é primo. e esta na posição " + j);
                }
            }

        }
    }
}