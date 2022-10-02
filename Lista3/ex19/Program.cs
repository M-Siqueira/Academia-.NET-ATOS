using System.Runtime.Intrinsics.X86;

namespace ex19
{
    internal class Program
    {

        //        19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
        //coletando dados sobre o salário e número de filhos.A prefeitura deseja saber: 


        //a) média do salário da população;
        //b) média do número de filhos;
        //c) maior salário;
        //d) percentual de pessoas com salário até R$ 100,00.
        //O final da leitura de dados se dará com a entrada de um salário negativo.


        static void Main(string[] args)
        {
            double salario, Msalario = 0;
            double filhos,Mfilho = 0;
            int cont = 0,cont2 = 0;
            double somaFilhos = 0, somaSalario = 0, maiorSalario = 0, percent = 0;

            while (true)
            {
                Console.WriteLine("qual salario?");
                salario = double.Parse(Console.ReadLine());

                if (salario < 0)
                {
                    break;
                }
                if (salario > 0 && salario < 101)
                {
                    cont2++;
                }
               
                Console.WriteLine("quantos filhos?");
                filhos = int.Parse(Console.ReadLine());

                somaFilhos = somaFilhos + filhos;

                somaSalario = somaSalario + salario;

                while(salario > maiorSalario)
                {
                    maiorSalario = salario; 
                }


                cont++;

                Msalario = (somaSalario / cont);
                Mfilho = (somaFilhos / cont);

                percent = (cont2 * 100) / cont;


            }

            Console.WriteLine("media salario: "+ Msalario);
            Console.WriteLine("media filhos: "+ Mfilho);
            Console.WriteLine("maior salario: "+ maiorSalario);
            Console.WriteLine("percentual com salario ate 100: " + percent );



        }
    }
}