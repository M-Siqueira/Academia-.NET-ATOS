using exFIgurinhaCopa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



public class Util
{

    //méotod de classe
    public static void gravarFraseArquivo(string frase, string nomeArquivo)
    {
        StreamWriter escritor = new StreamWriter(nomeArquivo, append: true); //abre o arquivo para escrita
        escritor.WriteLine(frase.ToUpper());
        escritor.Flush();
        escritor.Close();
    }
    public static void gravarFiguraArquivo(Figurinha figurinha, string nomeArquivo)

    {
        StreamWriter escritor = new StreamWriter(nomeArquivo, append: true); //abre o arquivo para escrita

        escritor.WriteLine(figurinha._codFigura + ";" + figurinha._selecao + ";" + figurinha._nomeJogador);
        escritor.Flush();
        escritor.Close();
    }

    public static void popularArquivoNaListaString(List<string> lista, string nomeArquivo)
    {
        try
        {

            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            do
            {
                lista.Add(leitor.ReadLine());
            } while (!leitor.EndOfStream);

            leitor.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Deu problema no arquivo!");
        }
    }

    public static void popularArquivoNaListaPessoa(List<Figurinha> lista, string nomeArquivo)
    {
        try
        {
            string linha;
            string[] dadosLinha;
            Figurinha figurinha;
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            do
            {
                linha = leitor.ReadLine();

                dadosLinha = linha.Split(";");

                figurinha = new figurinha(dadosLinha[0], dadosLinha[1], dadosLinha[2]);
                lista.Add(figurinha);

            } while (!leitor.EndOfStream);

            leitor.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Deu problema no arquivo!");
        }
    }

    public static void mostrarListaString(List<string> lista)
    {
        foreach (var i in lista)
        {
            Console.WriteLine(i);
        }
    }

    public static void mostrarListaPessoa(List<Figurinha> lista)
    {
        foreach (var i in lista)
        {
            Console.WriteLine("Nome: " + i._codFigura+ ". Email: " + i._selecao + ". Email: " + i._nomeJogador);
        }
    }

    public static bool jaNaListaPessoa(Figurinha pessoa, List<Figurinha> lista)
    {
        foreach (var i in lista)
        {
            if (figurinha._codFigura == i._codFigura)
            {
                return true; //pessoa localizada pelo email
            }
        }
        return false; //pessoa não localizada pelo email
    }
}