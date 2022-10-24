namespace Desafio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaAlunos = new List<string>();
            
            List<string> listaCompleta = new List<string>(); //sem cabeçalho



            Arquivos.importaArquivo(listaCompleta, listaAlunos, "arquivo.txt");

            Arquivos.mostraArquivos(listaCompleta, listaAlunos);//lista de alunos

            //Arquivos.mostraListaCompleta(listaCompleta);//lista completa de pessoas

            Aluno.buscaDados(listaAlunos, listaCompleta);

        }
    }
}