using System.Security.Cryptography.X509Certificates;

namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5.Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

            int i, j= 0, t = 8, aux;

            int[] vet = new int[t];
            int[] menorValor = new int[t];

            for (i = 0; i < t; i++)
            {
                Console.WriteLine("digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());

                for (j = 0; j < t; j++)
                {
                   
                }

            }
            Console.WriteLine("menor valor " + menorValor[j] +"posição: " + i);
        }
    }
}