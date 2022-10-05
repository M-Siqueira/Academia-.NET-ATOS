namespace ex11
{
    internal class Program
    {
       // Escreva um programa que leia valores em um vetor de 5 posições.Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

        static void Main(string[] args)
        {
            int[] vet = new int[5];
           

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("digite o numero: \n");
                vet[i] = int.Parse(Console.ReadLine());

            }

            for(int i = 0; i < 5; i++)
            {
                Console.Write(" - " + vet[i] + " - ");
            }

            Console.WriteLine("\n");

            for (int j = 4; j >= 0; j--)
            {
                Console.Write(" - " + vet[j]+" - ");
            }


        }
    }
}