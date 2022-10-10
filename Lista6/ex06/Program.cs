namespace ex06
{
    internal class Program
    {

        //        6. Continuação do exercício 1.
        //        Entretanto, quando listar os nomes, mostrar somente os sobrenomes.
        //Além disso, o programa deve mostrar as pessoas que são da mesma família.


        //        1. Fazer um programa em VS que popule uma lista de nomes, com nomes completos obrigatoriamente.
        //Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no mínimo duas palavras e
        //que não esteja na lista. Ao final, caso o nome não esteja na lista, cadastra-lo em maiúsculo.

        static void Main(string[] args)
        {

            List<string> nomePessoas = new List<string>();
            List<string> parente = new List<string>();

            string nomeCompleto;

            int continuar;

            string[] dadosNome;
            //cadastro do nomes na lista.
            do
            {
                Console.WriteLine("--------------");
                Console.WriteLine("0 - cadastrar.");
                Console.WriteLine("1 - listar.");
                Console.WriteLine("2 - sair.");
                Console.WriteLine("opcao: \n");
                int option = int.Parse(Console.ReadLine());


                switch (option)
                {
                    case 0:
                        //popular nomes compostos

                        Console.WriteLine("digite um nome composto:");

                        nomeCompleto = Console.ReadLine().ToUpper();

                        dadosNome = nomeCompleto.Split(" ");

                        if (nomeCompleto == "SAIR")
                        {   //sai do programa se digitar sair durante a insercao do nome composto
                            return;
                        }
                        if (dadosNome.Length >= 2)
                        {
                            if (nomePessoas.Contains(nomeCompleto))
                            {   //testa se o nome esta na lista e caso afirmativo, informa.
                                Console.WriteLine("ja existe na lista!");
                            }
                            else
                            {   //adiciona o nome na lista e informa.
                                nomePessoas.Add(nomeCompleto);
                                Console.WriteLine("cadastrado na lista");
                            }
                        }
                        else
                        {
                            //caso o nome estiver errado informa o erro.
                            Console.WriteLine("nome errado");
                        }

                        break;

                    case 1:
                        //listar nomes e nomes da mesma familia
                        Console.WriteLine("lista completa:");
                        foreach (string dado in nomePessoas)
                        {

                            Console.WriteLine(dado);
                        }

                        break;
                    case 2:
                        //sai do app.
                        return;
                }


            } while (true);


            //listando os nomes.

            foreach (var item in nomePessoas)
            {
                Console.WriteLine(item);
            }
        }
    }
}