using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace ex01
{
    internal class Program
    {
        //        1. Fazer um programa em VS que popule uma lista de nomes, com nomes completos obrigatoriamente.
        //Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no mínimo duas palavras e
        //que não esteja na lista. Ao final, caso o nome não esteja na lista, cadastra-lo em maiúsculo.

        static void Main(string[] args)
        {

            List<string> nomePessoas = new List<string>();

            string nomeCompleto;

            int continuar;

            string[] dadosNome;
            //cadastro do nomes na lista.
            do {

                Console.WriteLine("digite um nome composto:");

                nomeCompleto = Console.ReadLine().ToUpper();

                dadosNome = nomeCompleto.Split(" ");

                if(nomeCompleto == "SAIR")
                {   //sai do programa
                    break;
                }
                if(dadosNome.Length >= 2)
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


            } while (true);






            //listando os nomes.

            foreach (var item  in nomePessoas)
            {
                Console.WriteLine(item);            }




        }
    }
}