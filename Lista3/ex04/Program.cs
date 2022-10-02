using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            4.Em uma cidadezinha do interior há dois candidatos para prefeito(JOAO e ZECA).
            //Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
            //Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            //escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
            //de votos em branco.

            string candidato1, candidato2;
            int JOAO = 0, ZECA = 0,BRANCO = 0;

            do
            {
                Console.WriteLine("digite o nome do seu candidato: \n");

                candidato1 = Console.ReadLine();
                candidato2 = candidato1.ToUpper();//transformando em maiusculo para comparar.

                if (candidato2 == "JOAO")
                {
                    JOAO++;
                }
                if (candidato2 == "ZECA")
                {
                    ZECA++;
                }
                if (candidato2 == "BRANCO")
                {
                    BRANCO++;
                }

            } while (candidato2 != "FIM");

            Console.WriteLine("candidato Joao teve: \n" + JOAO + " votos!");
            Console.WriteLine("candidato zeca teve: \n" + ZECA + " votos!");
            Console.WriteLine("BRANCO teve: \n" + BRANCO + " votos!");

            //(candidato2 == "JOAO") || (candidato2 == "ZECA") || (candidato2 == "BRANCO")
        }
    }
}