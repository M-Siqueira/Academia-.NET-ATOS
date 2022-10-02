using System.Drawing;
using System.Runtime.Intrinsics.X86;
namespace ex18
{
    internal class Program
        {       // 18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer
                //elevada a um expoente qualquer, ou seja, NM.
        static void Main(string[] args)
        {
            double resp;
            

            Random n = new Random();
            int N = n.Next(0,5);

            Random m = new Random();
            int M = m.Next(0,5);


            resp = Math.Pow(N, M);

            Console.WriteLine(N);

            Console.WriteLine(M);

            Console.WriteLine("resultado: "+ resp);

        }
    }
}