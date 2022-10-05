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
            int t = 5, i, j, posicao = 4;
            int[] entrada = new int[t];
            int[] saida = new int[t];
            int[] extra = new int[t];


            for (i = 0; i < t; i++)
            {
                Console.WriteLine("digite um inteiro: \n");
                entrada[i] = int.Parse(Console.ReadLine());
                
               
            }
            for (j = 0; j < t; j++)
            {
                extra[posicao] = entrada[j];

                posicao--;
            }



            for (j = 0; j < t; j++)
            {
                Console.WriteLine("posicao:"+j+" " + saida[j]);
            }


            for (j = 0; j < t; j++)
            {
                Console.WriteLine("saida" + saida[j]);
            }

        }    
    }
}