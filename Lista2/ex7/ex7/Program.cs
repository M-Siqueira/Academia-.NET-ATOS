namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string frase, palavra;

            Console.WriteLine("digite sua frase: \n");
            frase = Console.ReadLine();

            Console.WriteLine("palavra a pesquisar: \n");
            palavra = Console.ReadLine();

            Console.WriteLine("\n");

            if (frase.Contains(palavra))
            {
                Console.WriteLine(palavra + " ncontrada nesta frase!");
            }
            else
            {
                Console.WriteLine(palavra + " nao existe na frase!");
            }
        }
    }
}