using System.Diagnostics;

namespace conta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente();

            cli.nome = "fabricio";
            cli.idade = 22;

            Conta c = new Conta(cli,10000,"corrente");
            

            while (true)
            {

                Console.WriteLine("escolha sua opçao: ");
                int option = int.Parse(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        Console.WriteLine("valor a ser depositado: ");
                        c.deposito(double.Parse(Console.ReadLine()));

                        break;
                    case 2:
                        Console.WriteLine("valor a ser sacado: ");
                        c.saque(double.Parse(Console.ReadLine()));

                        break;

                    case 3:
                        Console.WriteLine("saldo é: " + c.getSaldo());
                        break;

                        default:

                        Console.WriteLine("o cliente " + c.cliente.nome + " saldo "+ c.getSaldo());
                        return;
                }
            }
        }
    }
}