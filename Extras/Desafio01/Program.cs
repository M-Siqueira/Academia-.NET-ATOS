namespace Desafio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaAlunos = new List<string>();
            List<string> listaPessoas = new List<string>();
            List<string> listaCompleta = new List<string>();



            Arquivos.importaArquivo(listaCompleta, "arquivo.txt");

            Arquivos.mostraArquivos(listaCompleta);
        }
    }
}