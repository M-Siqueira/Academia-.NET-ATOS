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

        public static void importaArquivo(List<string> listaCompleta, string nomeArquivo)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //ler o arquivo txt e importar para lista

            string linha;
            string[] dadosLinha;

            Pessoa pessoa;
            do
            {
                linha = leitor.ReadLine();
                dadosLinha = linha.Split(";");

                pessoa = new Aluno(dadosLinha[0], dadosLinha[1], dadosLinha[2], dadosLinha[3], dadosLinha[4], dadosLinha[5], dadosLinha[6], dadosLinha[7], dadosLinha[8], dadosLinha[9]);
                listaCompleta.Add(linha);

                if (dadosLinha[0] == "Z")
                {
                    //dados pessoas

                }else if(dadosLinha[0] == "Y")
                {
                    //dados pessoas que sao alunos
                }

                
            }while (leitor.EndOfStream);


            leitor.Close();

            //teoricamente a lista esta populada por completo
        }



        public static void mostraArquivos(List<string> listaCompleta)
        {
           foreach (string linha in listaCompleta)
            {
                Console.WriteLine(linha);
            }
        }













        public void gravaArquivo()
        {
            StreamWriter gravador = new StreamWriter("arquivo.txt",append:true);//gravar o arquivo no txt apendando.

            gravador.Flush();//boa pratica 
            gravador.Close();//fecha gravalçao
        }



    }
}
