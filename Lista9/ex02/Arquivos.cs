using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Arquivos
    {

        public static void populaEmail(List<string>lista, string nomeArquivo)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            do
            {
                lista.Add(leitor.ReadLine());

            }while(!leitor.EndOfStream);
            leitor.Close();
        }



        public void cadastraEmail(List<string> listaEmail, string emailM)
        {
            StreamWriter cadastro = new StreamWriter( "email.csv" , append:true);

            listaEmail.Add(emailM);
            cadastro.WriteLine(emailM);
            cadastro.Flush();
            cadastro.Close();

        }

        public static void listaEmail(List<string> listaEmail)
        {
            foreach (string email in listaEmail)
            {
                Console.WriteLine(email);
            }
        }



    }
}
