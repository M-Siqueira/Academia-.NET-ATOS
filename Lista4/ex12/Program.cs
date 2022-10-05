namespace ex12
{
    internal class Program
    {
       // Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor.
       // Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".

        static void Main(string[] args)
        {
            int[] v = new int[5];
            int N,cont = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("digite o valor: \n");
                v[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("procura um numero dentro do vetor:\n");
            N = int.Parse(Console.ReadLine());

            for (int j = 0 ; j < 5 ; j++ )
            {
                
                    if (N == v[j])
                    {
                        Console.WriteLine("numero encopntrado no vetor na posicao " + j);
                        break;

                    }if(cont == 4)
                {
                    Console.WriteLine("O número fornecido não existe no vetor!");
                } 
                cont++;
            }


        }
    }
}