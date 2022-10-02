using System.Net;

namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12.Apresentar o total da soma dos cem primeiros números inteiros.

            float entrada;
            int soma = 0, auxiliar, cont = 0;
            do
            {

                Console.WriteLine("digite um numero inteiro");
                entrada = float.Parse(Console.ReadLine());

                auxiliar = (int)entrada;

                if ((entrada / 1) == auxiliar)
                {
                    soma += auxiliar;

                    //Console.WriteLine("inteiro: \n");
                    //Console.WriteLine("soma: " + soma);
                }
                if ((entrada / 1) != auxiliar)
                {
                    Console.WriteLine("nao é inteiro");
                }
                cont++;

            } while (cont < 10);
            Console.WriteLine("soma: " + soma);
        }
    }
}