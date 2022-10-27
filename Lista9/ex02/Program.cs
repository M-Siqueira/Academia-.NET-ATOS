using System.Threading.Channels;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaEmail = new List<string>();

            Arquivos arqEmail = new Arquivos();

            string option = "a";

            Arquivos.populaEmail(listaEmail, "email.csv");//popular a lista de arquivos buscando do arquivo salvo 

            Console.WriteLine("posicao de escrita " + listaEmail.Count);

            while(option != "3")
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("MENU:");
                Console.WriteLine("1- Cadastro de Emails");
                Console.WriteLine("2- Listar Emails");
                Console.WriteLine("3- sair");
                Console.WriteLine("----------------------");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        //cadasttrar os emails usando metodos da classe arquivos tbm verifica duplicidade 
                        Console.WriteLine("digite seu Email por favor...");
                        string email = Console.ReadLine();
                        string emailM = email.ToUpper();

                        if (listaEmail.Contains(emailM))
                        {
                            Console.Clear();
                            Console.WriteLine("o email ja existe na lista");
                            continue;

                        }
                        if (emailM.Contains("@") && emailM.Contains(".COM"))
                        {
                            Console.Clear();
                            Console.WriteLine("é um email...");

                            arqEmail.cadastraEmail(listaEmail, emailM);

                        }
                        if ((!emailM.Contains("@")) || (!emailM.Contains(".COM")))
                        {
                            Console.Clear();
                            Console.WriteLine("nao é um email.....");

                        }
                        break;

                    case "2":
                        //listar usando metodo da classe arquivo
                        Console.Clear();
                        Console.WriteLine("lista de emails cadastrados na lista e na base de dados");
                        Arquivos.listaEmail(listaEmail);

                        continue;


                    case "3":

                        Console.WriteLine("saindo");

                        continue;

                }
            }

        }
    }
}