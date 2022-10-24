namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaEmail = new List<string>();
            Arquivos arqEmail = new Arquivos();

            string option;

            Arquivos.populaEmail(listaEmail, "email.csv");//popular a lista de arquivos buscando do arquivo salvo 

            Console.WriteLine("posicao de escrita " + listaEmail.Count);


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
                    //cadasttraros emails usando metodos da classe arquivos
                    Console.WriteLine("digite seu Email por favor...");
                    string email = Console.ReadLine();
                    string emailM = email.ToUpper();

                    if (emailM.Contains("@") && emailM.Contains(".COM"))
                    {
                        Console.WriteLine("é um email...");

                        arqEmail.cadastraEmail(listaEmail,emailM);

                    }
                    if (!emailM.Contains("@") && !emailM.Contains(".COM"))
                    {
                        Console.WriteLine("nao é um email.....");
                    }
                    else
                    {
                        Console.WriteLine("ultimo else");
                    }





                        break;
                case "2":
                    //listar usando metodo da classe arquivo
                    break;
                case "3":
                    //sair. 
                    break;
            }

        }
    }
}