namespace ex08
{
    internal class Program
    {
        //        8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor.Exemplo:
        //a.lê:          	|5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
        //b.escreve: 	|3|5|6|7|9|10|14|. . .
        static void Main(string[] args)
        {
            int[] mat = new int[5];
            int posicao=10000000, valor;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("escreva o valor real: \n");
                mat[i] = int.Parse(Console.ReadLine());

            }




            for(int i = 0; i < 5; i++)

            {
                if (mat[i] < 0)
                {
                    posicao = i;
                    Console.Write("[" + mat[i]+"] posição: "+ (posicao+1)+" ");

                }
            }

        }
    }
}