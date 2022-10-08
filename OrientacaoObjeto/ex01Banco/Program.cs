using System.Drawing;

namespace ex01Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conta;
            string agencia;
            int tipo;
            double valor,saque;

            Console.WriteLine("conta:");
            conta = Console.ReadLine();

            Console.WriteLine("agencia:");
            agencia = Console.ReadLine();

            Console.WriteLine("tipo:");
            tipo = int.Parse(Console.ReadLine());

            Console.WriteLine("valor:");
            valor = double.Parse(Console.ReadLine());

            Transacao t = new Transacao(agencia, tipo, valor, conta);


            t.exibeDados();

            Console.WriteLine("valor do saque");
            saque = double.Parse(Console.ReadLine());

            t.saque(saque);

        }
    }
}