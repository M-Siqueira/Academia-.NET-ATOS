namespace ex10
{
    internal class Program
    {
        //10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições.Crie um segundo vetor,
        //substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.

        static void Main(string[] args)
        {
            int[] vet1 = new int[10], resultado = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("digite o numero:");
                vet1[i] = int.Parse(Console.ReadLine());

                resultado[i] = vet1[i];

                if (vet1[i] == 0)
                {
                    vet1[i] = 2;
                }

            }

            Console.WriteLine("vetor lido \n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("posicao"+i+" numero : " + resultado[i]);
            }
            Console.WriteLine("  \n");
            Console.WriteLine("vetro resultado \n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("posicao" + i + " numero : " + vet1[i]);
            }
        }
    }
}