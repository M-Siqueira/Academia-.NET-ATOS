using System.Collections.Generic;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace ex04
{
    internal class Program
    {
        //        4. Fazer um programa em VS que realize um CRUD(inserir, pesquisar, atualizar e deletar)
        //completo em uma lista de nomes de criptomoedas.
        //Neste programa, somente o nome da criptomoeda deve
        //ser cadastrado (em maiúsculo).
        //Ao cadastrar, não pode haver duplicidade de dados na lista.
        //Sempre
        //que a opção listar for acionada, a listagem deve ser exibida de forma ordenada.
        //No processo de
        //remoção, o usuário entra com o nome da criptomoeda que deseja remover.Caso o programa a encontre,
        //deve remover e avisar o usuário que a operação ocorreu corretamente, e caso não a encontre, avisar
        //ao usuário que nome não foi encontrado.

        //Menu
        //1 - Cadastrar criptomoeda 
        //2 - Listar criptomoedas
        //3 - Remover criptomoeda
        //4 - Sair
        //Opção: 


        static void Main(string[] args)
        {
            List<string> criptomoeda = new List<string>();
            //string[] maiuscula;
            string nome;
            int numero;

            while (true)
            {

                Console.WriteLine("cryptomoedas:\n");
                Console.WriteLine("1- cadastro de crypto:\n");
                Console.WriteLine("2- listar crypto:\n");
                Console.WriteLine("3- remover crypto:\n");
                Console.WriteLine("4- sair:\n");
                Console.WriteLine("opção:\n");
                numero = int.Parse(Console.ReadLine());
                Console.Beep();

                switch (numero)
                {
                    case 1:
                        //cadastrar as cryptos maiusculas sem permitir duplicidade na lista
                        Console.WriteLine("nome da cripto:");
                        nome = Console.ReadLine();

                        string maiuscula = nome.ToUpper();
                        Console.WriteLine("\n");

                        if (criptomoeda.Contains(maiuscula))
                        {
                            Console.WriteLine("crypto já existente");
                            Console.WriteLine("\n");
                            break;
                        }
                        else
                        {
                            criptomoeda.Add(maiuscula);

                            Console.WriteLine(maiuscula + " anexado na lista.");
                            Console.WriteLine("\n");
                        }

                        break;
                    case 2:
                        //listar crypto
                        foreach(string s in criptomoeda)
                        {
                            Console.WriteLine(s);
                        }

                        break;
                    case 3:
                        //deletar crypto

                        Console.WriteLine("qual cripto deletar?: \n");
                        string apagar = Console.ReadLine().ToUpper();

                        if (criptomoeda.Contains(apagar))
                        {

                            criptomoeda.Remove(apagar);
                            Console.WriteLine("crypto já apagada");
                            Console.WriteLine("\n");
                            break;
                        }

                        break;
                    case 4:
                        //sair
                        return;
                }//fechamento do swhitch
            }//fechamento do while.








        }
    }
}