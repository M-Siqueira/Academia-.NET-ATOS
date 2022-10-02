namespace soma_dos_vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetA = new int[10], vetB = new int[10];

            int i, produto = 0,linha;

            Console.WriteLine("leitura de elementos: \n");
            for (i = 0; i < 10 ; i++)
            {
                Console.WriteLine("numero posicao de a: \n");
                vetA[i]= int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("numero posicao de b: \n");
                vetB[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                linha = vetA[i] * vetB[i];
                produto = produto + linha;
            }
            Console.WriteLine("produto é : "+produto);
        }
    }
}