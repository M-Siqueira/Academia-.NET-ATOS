using static System.Net.Mime.MediaTypeNames;
using System.Runtime.ConstrainedExecution;

namespace ex10
{
    internal class Program
    {

        //        10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
        //Número de pessoas do sexo masculino.
        //Número de pessoas do sexo feminino.
        //Número de pessoas com idade inferior a 30 anos.
        //Número de pessoas com idade superior a 60 anos.
        //Média de idade das mulheres.
        static void Main(string[] args)
        {
            string nome, sexo;
            int idade, mediaIdade;
            int masc = 0, fem = 0,menosIdade = 0,maisIdade = 0,pessoas = 0;

            do
            {

                Console.WriteLine("qual seu nome?");
                nome = Console.ReadLine();

                Console.WriteLine("qual seu sexo? (M ou F)\n");
                sexo = Console.ReadLine();

                string SEXO = sexo.ToUpper();
                

                Console.WriteLine("qual sua idade?");
                idade = int.Parse(Console.ReadLine());

                if (SEXO == "M"|| SEXO == "MASCULINO"|| SEXO == "MASC")
                {

                    masc++;
                }
                if (SEXO == "F" || SEXO == "FEMININO"||SEXO == "FEM")
                {
                    
                    idade += idade;
                    fem++;
                }
                if (idade < 30)
                {
                    menosIdade++;
                }
                if (idade > 60)
                {
                    maisIdade++;
                }


                pessoas++;

            } while (pessoas < 3);

            mediaIdade = (idade / fem);

            Console.WriteLine(masc + " pessoas do sexo masculino.\n");
            Console.WriteLine(fem + " pessoas do sexo feminino.\n");
            Console.WriteLine("a media de idade das mulheres é . "+mediaIdade+" \n");

            Console.WriteLine(menosIdade + " pessoas com menos de 30 anos.\n");
            Console.WriteLine(maisIdade + " pessoas com mais de 60 anos.\n");
        }
    }
}