using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exExtraForms
{
    internal class Ferramentas
    {
        public void PopulaArquivoLista(List<Player>players, List<string> nomes, List<string> emails, string nomeArquivo)
        {
            string linha;
            string[] dadosLinha;

            string nome;
            string email;

            Player jogador;

            

            StreamReader sr = new StreamReader(nomeArquivo, Encoding.UTF8);

            do
            {
                linha = sr.ReadLine();
                dadosLinha = linha.Split(";");
                jogador = new Player(dadosLinha[0], dadosLinha[1]);
                players.Add(jogador);

                nome = new string(dadosLinha[0]);
                nomes.Add(nome);
                email = new string(dadosLinha[1]);
                emails.Add(email);  

            }while (!sr.EndOfStream);
            sr.Close();

        }

        public void GravaArquivo(List<Player> players, string NomeArquivo)
        {


            if (!File.Exists(NomeArquivo))
            {
                StreamWriter escritor = new StreamWriter(NomeArquivo, append: true);//cria um novo arquivo 
                foreach (Player player in players)
                {
                    escritor.WriteLine(player.PlayerName + ";" + player.PlayerEmail);
                }


                escritor.Flush();
                escritor.Close();
            }
            else
            {

                StreamWriter escritor = new StreamWriter(NomeArquivo);

                foreach (Player player in players)
                {
                    escritor.WriteLine(player.PlayerName + ";" + player.PlayerEmail);
                }


                escritor.Flush();
                escritor.Close();
            }


            

        }

        




























    }
}
