namespace ex09
{
    internal class Program
    {
        //9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

        static void Main(string[] args)
        {
            int[] vet = new int[10];

            int aux;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("digite um valor: \n");
                vet[i] = int.Parse(Console.ReadLine());

            }
            for(int x = 0; x < 10; x++)
            {
                for(int j = x; j < 10; j++)
                {
                    if (vet[x] > vet[j])
                    {

                        aux = vet[x];
                        vet[x] = vet[j];
                        vet[j] = aux;

                    }
                }

            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("posicao: "+i+" "+vet[i]);
                    
            }

        }
    }
}