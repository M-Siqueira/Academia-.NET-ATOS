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



            Console.WriteLine("decisao:");
            numero = int.Parse(Console.ReadLine());



            switch (numero)
            {
                case 1:

                    Console.WriteLine("nome da cripto:");
                    nome = Console.ReadLine();

                    string maiuscula = nome.ToUpper();

                    Console.WriteLine(maiuscula);

                    break;
                case 2:
                    //cod
                    break;
                case 3:
                    //cod
                    break;
            }



        }
    }
}