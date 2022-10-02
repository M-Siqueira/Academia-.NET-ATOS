using System.Runtime.Intrinsics.X86;

namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            9.Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram
            //o zoológico num determinado dia, imprimindo:
            //Quantas pessoas tem entre 1 e 3 filhos.
            //Quantas pessoas tem entre 4 e 7 filhos.
            //Quantas pessoas tem mais de 8 filhos.
            //Quantas pessoas não tem filhos.
            int pessoas = 0, filhos;
            int a = 0, b = 0, c = 0, d = 0;

            Console.WriteLine("zoo da atos, venha ser um leao da programação\n");

            do
            {

                Console.WriteLine("quantos filhos tem ?");
                filhos = int.Parse(Console.ReadLine());

                if (filhos > 0 && filhos < 4)
                {

                    a++;
                }
                if (filhos > 3 && filhos < 8)
                {
                    b++;
                }
                if (filhos > 8)
                {
                    c++;
                }
                if (filhos == 0)
                {
                    d++;
                }


                pessoas++;

            } while (pessoas < 10);

            Console.WriteLine(a + " pessoas tem entre 1 e 3 crianças.\n");
            Console.WriteLine(b + " pessoas tem entre 4 e 7 crianças.\n");
            Console.WriteLine(c + " pessoas tem mais de 8 crianças.\n");
            Console.WriteLine(d + " pessoas nao tem crianças.\n");

            //conforme o enunciado ele nao contabiliza quem tem exatamente 8 crianças
        }
    }
}