namespace exemplo_maior_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];
            int i, mauior, posicao;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("digite um valor inteiro: \n");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            mauior = vetor[0];
            posicao = 0;

            for (i = 0; i < 5; i++)
            {
                if (vetor[i] > mauior)
                {

                    mauior = vetor[i];
                    posicao = i;
                }
            }
            Console.WriteLine("maior: " + mauior + "posicao " + posicao);
        }

       
    }
}