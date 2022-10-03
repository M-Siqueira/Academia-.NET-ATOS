using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace ex2
{
    internal class Program
    {       //2.	Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição,
            //armazenando o resultado em um outro vetor.


        static void Main(string[] args)
        {
            int t = 20;
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
                resposta[i] = valoresA[i] + valoresB[i];

                Console.WriteLine("a soma do valor na posicao A com B:" + resposta[i]);
            }



        }
    }
}