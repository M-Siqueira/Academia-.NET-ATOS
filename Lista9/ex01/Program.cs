using static System.Net.Mime.MediaTypeNames;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            string nome;
            string option;

            nomes.Clear();//limpa a lista antes de chamar o metodo popula para trazer do arquivo os integrantes.

            Arquivo.populaLista(nomes, "arquivo.txt");

            if(nomes.Count == 3) // 4 posicoes. 1 é um linha em branco e ultima é uma linha em branco
            {
                Console.WriteLine("lista cheia.....");
                // Console.Clear();
                
                Environment.Exit(0);
            }

            Console.WriteLine("mostrar dados tecle 1\nsair tecle 2\ncadastrar tecle 3");
            //Console.WriteLine(nomes.Count);
            option = Console.ReadLine();

            if (option == "1")
            {
                Arquivo.mostraDados(nomes);
            }
            if (option == "2")
            {
                Console.Clear();

                Environment.Exit(0);

            }if(option == "3")
            {
                do
                {
                    Console.WriteLine("digite seu nome: ");
                    nome = Console.ReadLine();


                    string nomeM = nome.ToUpper();

                    if (nomeM.Contains(" ") && !nomes.Contains(nomeM) && nomes.Count < 4)
                    {


                        nomes.Add(nomeM); // salva na lista
                        Arquivo.salvaArquivo(nome.ToUpper(), "arquivo.txt");//salvando em arquivo apendado.

                    }
                    else if (!nomeM.Contains(" "))
                    {
                        Console.WriteLine("nome nao composto.......");
                        Console.WriteLine("continue tentando cadastrar......");
                        continue;
                    }
                    else if (nomes.Contains(nomeM))
                    {
                        Console.WriteLine("nome ja existe na lista...");
                        continue;
                    }





                } while (nomes.Count < 4);

            }


            

            
        }
    }
}