using System.Runtime.Intrinsics.X86;
using System.Xml;

namespace ex11
{
    internal class Program
    {

        //        11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
        //a média aritmética da turma e a quantidade de alunos da turma.Usar -1 para encerrar a leitura.

        static void Main(string[] args)
        {
            float mediaArit;
            float nota = 0,soma = 0,maiorNota = 0, menorNota = 0;
            int alunos = 0; 

            while(nota >= 0 )
            {
                Console.WriteLine("entre com a primeira nota do aluno da turma: \n");
                nota = int.Parse(Console.ReadLine());
                if (nota >=0)
                {
                    soma += nota;
                }
                if (nota > maiorNota)
                {
                    maiorNota = nota;
                }
                if ((nota < menorNota) && (nota != -1) )
                {
                    menorNota = nota;
                }
                alunos++;

            }

           



            mediaArit = (soma / (alunos - 1));
            
            Console.WriteLine("total de alunos: "+ (alunos - 1 ) );
            Console.WriteLine("\n");
            Console.WriteLine("total das nota: " + soma);
            Console.WriteLine("\n");
            Console.WriteLine("total da media A: "+ mediaArit);
            Console.WriteLine("\n");
            Console.WriteLine("maior nota: " + maiorNota);
            Console.WriteLine("\n");
            Console.WriteLine("menor nota: " + menorNota);
        }
    }
}