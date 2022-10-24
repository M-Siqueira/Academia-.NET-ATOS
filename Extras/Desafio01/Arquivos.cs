using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Desafio01
{
    internal class Arquivos
    {

        public static void importaArquivo(List<string> listaCompleta, List<string> listaAlunos, string nomeArquivo)
        {
            string linha;

            string[] dadosLinha;

            int numeroLinhas = 0;

            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //ler o arquivo txt e importar para lista
            do
            {
                linha = leitor.ReadLine();

                numeroLinhas++;

                dadosLinha = linha.Split("-");

                int num = dadosLinha.Count();

                int contaAluno = 0;
                int contaPessoa = 0;

                string inicial;

                inicial = dadosLinha[0];



                if (inicial == "X")     //inicia com x ignora linha
                {
                    //Console.WriteLine("inicial x e tem " + num + " dados" );teste

                    continue;
                }
                if (inicial == "Y")//inicia com y é aluno
                {
                    //Console.WriteLine("inicial y");teste

                    for (int i = 0; i < num; i++)
                    {
                        listaAlunos.Add(dadosLinha[i]);

                        contaAluno++;
                    }


                    continue;
                }
                if (inicial == "Z")//inicia com z é pessoa
                {
                    //Console.WriteLine("inicial z");teste

                    for (int i = 0; i < num; i++)
                    {

                        listaCompleta.Add(dadosLinha[i]);

                        contaPessoa++;

                    }

                    continue;
                }



            } while (!leitor.EndOfStream);

            Console.WriteLine("numero de linhas lidas " + numeroLinhas);//teste

            leitor.Close();




            //teoricamente a lista esta populada por completo
        }



        public static void mostraArquivos(List<string> listaCompleta, List<string> listaAlunos)
        {
            

            Console.WriteLine("-----------------------------");
            Console.WriteLine("lista completa de pessoas");
            foreach (string linha in listaCompleta)
            {
                Console.Write("[" + linha + "]-");
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("lista de alunos");
            foreach (string linha in listaAlunos)
            {

                Console.Write("["+linha+"]-");
            }
            Console.WriteLine("-----------------------------");
        }








        public static void mostraAlunos(List<string> listaAlunos)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("lista de alunos");
            foreach (string linha in listaAlunos)
            {

                Console.Write("[" + linha + "]-");
            }
            Console.WriteLine("-----------------------------");
        }


        public static void mostraListaCompleta(List<string> listaCompleta)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("lista de alunos");

            foreach (string linha in listaCompleta)
            {
                Console.Write("[" + linha + "]-");
            }
            Console.WriteLine("-----------------------------");
        }


    }
}
