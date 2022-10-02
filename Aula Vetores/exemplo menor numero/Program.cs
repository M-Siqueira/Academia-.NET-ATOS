namespace exemplo_menor_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];
            int i, menor,maior, posicaoMaior, posicaoMenor;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("digite um valor inteiro: \n");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            menor = vetor[0];
            maior = vetor[0];
            posicaoMaior = 0;
            posicaoMenor = 0;

            for (i = 0; i < 5; i++)
            {
                if (vetor[i] < menor) {

                    menor = vetor[i];
                    posicaoMenor = i;
                }
                if (vetor[i] > maior )
                {

                    maior = vetor[i];
                    posicaoMaior = i;
                }
            }

            Console.WriteLine("menor: " + menor + "posicao " + posicaoMenor);

            Console.WriteLine("maior: " + maior + "posicao " + posicaoMaior);
        }
    }
}