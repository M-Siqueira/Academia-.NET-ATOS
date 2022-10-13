using System.Security.Cryptography;

namespace ooPessoa
{
    internal class Program
    {
        static List<Pessoa> pessoas;// global 
        static void Main(string[] args)
        {
            int contador = 0; // variavel apenas para mostrar a posicao no foreach.

            pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa(10, "ricardo"));
            pessoas.Add(new Pessoa(20, "antenor"));
            pessoas.Add(new Pessoa(30, "ausente"));

            foreach (var pessoa in pessoas)
            {
                contador++;
                Console.WriteLine(pessoa.Nome + " " + pessoa.Idade + " na posicao " + (contador));
            }
            naoOredenada();
            OredenadaNome();
            Oredenadaidade();

        }

        static void naoOredenada()
        {
            Console.WriteLine("nao ordenada: \n");

            pessoas.ForEach(delegate (Pessoa pessoas)
            {

                Console.WriteLine(" " + pessoas.Idade + " " + pessoas.Nome);

            });

        }

        static void OredenadaNome()
        {
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
                {

               return p1.Nome.CompareTo(p2.Nome);

                });

            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });


        }


        static void Oredenadaidade()
        {
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
            {

                return p1.Idade.CompareTo(p2.Idade);

            });

            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });


        }

        //FindAll(delegate)
        //Find()
        //foreach
        //sort
        //CompareTo
        //



    }
}



//insert in to "vazio" na garagem. 
//dicionarios ........