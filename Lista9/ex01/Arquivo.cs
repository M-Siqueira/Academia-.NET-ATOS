using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    internal class Arquivo
    {

        public static void populaLista(List<string> lista , string nomeList)
        {
            StreamReader leitura = new StreamReader(nomeList,Encoding.UTF8);
            do
            {
                Console.Clear();
                Console.WriteLine("carregando dados na lista....");

                lista.Add(leitura.ReadLine());
                
            }while(!leitura.EndOfStream);

            leitura.Close();

        }//popula a lista antes de fazer os cadastrios de novos integrantes




        public static void salvaArquivo(string nome, string nomeArquivo)
        {
            StreamWriter escrita = new StreamWriter(nomeArquivo, append: true);
            escrita.WriteLine(nome);
            escrita.Close();

            Console.WriteLine(nome); 
        }





        public static void mostraDados(List<string> nomes)
        {
          nomes.Sort();

            foreach (var i in nomes)
            {
                Console.WriteLine(i);
            }
        }

    }
}
