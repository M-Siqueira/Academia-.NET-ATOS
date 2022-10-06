using System.Collections.Generic;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace ex03
{
    internal class Program
    {
        //        3. Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
        //        Os emails digitados devem ser cadastrados em uma lista e não pode haver emails duplicados, ou seja,
        //o programa deve controlar essa situação.
        //Quando o usuário solicitar a listagem dos emails, além dessa
        //lista, o programa deve listar os domínios de emails cadastrados no programa.

        //Menu
        //1 - Cadastrar email
        //2 - Listar
        //3 - Sair
        //Opção: 

        static void Main(string[] args)
        {

            List<string> email = new List<string>();

            string entradaEmail;
            //string[] dadosEmail;

            int opcao;

            do
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1 - Cadastro de email.");
                Console.WriteLine("2 - listagem de email.");
                Console.WriteLine("3 - sair.");
                Console.WriteLine("\n");
                Console.WriteLine("opçao:");
                opcao = int.Parse(Console.ReadLine());
                Console.Beep();


                //kkkkkk. gostei disso. 


                switch (opcao)
                {


                    case 1:

                        do
                        {
                            Console.WriteLine("qual seu email");
                            entradaEmail = Console.ReadLine().ToUpper();
                            string[] dadosEmail = entradaEmail.Split("@");

                            if (entradaEmail == "SAIR")
                            {
                                break;
                            }
                            if (dadosEmail.Length >= 2)
                            {
                                if (email.Contains(entradaEmail.ToUpper()))
                                {
                                    Console.WriteLine("ja esta presenta na lista");

                                }
                                else
                                {
                                    email.Add(entradaEmail);
                                    Console.WriteLine("add na lista");
                                }

                            }
                            else
                            {
                                Console.WriteLine("erro de digitacao.");
                            }



                        } while (true);


                        break;
                    case 2:
                        foreach (string s in email)
                        {
                            Console.WriteLine(s);
                        }

                        Console.WriteLine("\n");

                        for (int i = 0; i < email.Count; i++)
                        {
                            Console.WriteLine(email[i]);
                        }
                        break;
                    case 3:
                        Console.WriteLine("saindo");
                        return;
                }


            }while (true);

            //foreach (string s in email)
            //{
            //    Console.WriteLine(s);
            //}


        }
    }
}