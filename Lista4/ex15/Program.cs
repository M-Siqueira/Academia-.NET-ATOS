using System.Globalization;

namespace ex15
{
    internal class Program
    {
        //15.	Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor,
        //invertendo sua ordem.
        //Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo.
        //Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.


        static void Main(string[] args)
        {
            int t = 5, i, j;
            int[] entrada = new int[t];
            int[] saida = new int[t];
            
            for (i = 0; i < t; i++)
            {
                Console.WriteLine("digite um inteiro: \n");
                entrada[i] = int.Parse(Console.ReadLine());
                
                saida[4-i] = entrada[i];
               
            }
            
            for (j = 0; j < t; j++)
            {
                Console.Write("[" + j + "]=" + entrada[j]+"   ");
            }

            Console.WriteLine("\n");

            for (j = 0; j < t; j++)
            {
                Console.Write("[" + j + "]=" + saida[j]+"   ");
            }

        }    
    }
}