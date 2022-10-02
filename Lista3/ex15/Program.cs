using System.Runtime.Intrinsics.X86;

namespace ex15
{
    internal class Program
    {
        //        15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado
        //ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente.
        //Considerar nota 7,0 como mínima para aprovação.

        static void Main(string[] args)
        {
            float n1, n2, n3, n4;
            float Mp;

            Console.WriteLine("qual nota do aluno? \n");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("qual nota do aluno? \n");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("qual nota do aluno? \n");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("qual nota do aluno? \n");
            n4 = float.Parse(Console.ReadLine());

            Mp = ((n1 * 2) + (n2 * 1) + (n3 * 2) + (n4 * 4)) / (2 + 1 + 2 + 4);

            if (Mp >= 7)
            {
                Console.WriteLine("aprovado");
            }
            else
            {
                Console.WriteLine("reprovado");
            }
        }
    }
}