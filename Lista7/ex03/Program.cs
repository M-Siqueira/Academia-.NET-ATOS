using static System.Net.Mime.MediaTypeNames;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //cad cliente

            Console.WriteLine("nome do cliente:");
            string nome = Console.ReadLine();

            Console.WriteLine("idade");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("data emissao cnh:");
            int datacnh = int.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nome, idade, datacnh);

            cliente.ClienteApto(idade, datacnh);





            //cad carro

            Console.WriteLine("marca do carro:");
            string marca = Console.ReadLine();

            Console.WriteLine("modelo do carro");
            string modelo = Console.ReadLine();

            Console.WriteLine("cor do carro:");
            string cor = Console.ReadLine();

            Console.WriteLine("placa do carro:");
            string placa = Console.ReadLine();


            Carro carro = new Carro(marca, modelo, cor, placa);



            //cad aluguel


            Console.WriteLine("km inicial do carro:");
            string kmInicio = Console.ReadLine();

            Console.WriteLine("data locação:");
            string dataLocacao = Console.ReadLine();

            Console.WriteLine("taxa de locação:");
            int taxaAluguel = int.Parse(Console.ReadLine());

            Console.WriteLine("taxa de seguro:");
            int taxaSeguro = int.Parse(Console.ReadLine());


            Aluguel aluguel = new Aluguel(taxaAluguel, taxaSeguro, dataLocacao, carro, cliente);
















        }
    }
}