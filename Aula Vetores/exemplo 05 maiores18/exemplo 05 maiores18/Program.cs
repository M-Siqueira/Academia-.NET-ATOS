namespace exemplo_05_maiores18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int[4];
            int i, Conta = 0;
            Console.WriteLine("idedes? ");
            for (i = 0; i < idade.Length; i++)
            {
                idade[i] = int.Parse(Console.ReadLine());
                if (idade[i] >= 18)
                {
                    Conta++;
                }

            }
            Console.WriteLine("maiores "+ Conta);

            for (i = 0; i < 4; i++)
            {
                if (idade[i] < 18)
                {
                    Console.WriteLine("aluno posicao "+ i + " tem "+ idade[i]+" anos");
                }
            }
        }
    }
}