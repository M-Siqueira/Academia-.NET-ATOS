namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            do
            {
                Console.WriteLine("0- cadastro");
                Console.WriteLine("1- sair");
                Console.WriteLine("2- sair");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:

                        string nome, cartao;
                        int idade, datacnh;


                        Console.WriteLine("nome do cliente:");
                        nome = Console.ReadLine();

                        Console.WriteLine("idade");
                        idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("data emissao cnh:");
                        datacnh = int.Parse(Console.ReadLine());

                        Console.WriteLine("numero do cartao de credito para cadastro:");
                        cartao = Console.ReadLine();

                        Cliente cliente = new Cliente(nome, idade, datacnh, cartao);

                        cliente.ClienteApto(idade,datacnh);

                        break;
                    case 1:


                        break;
                    case 2:



                        break;
                }



            } while (true);









            //cad cliente

            





            //cad carro
            string marca, modelo, cor, placa;



            Console.WriteLine("marca do carro:");
            marca = Console.ReadLine();

            Console.WriteLine("modelo do carro");
            modelo = Console.ReadLine();

            Console.WriteLine("cor do carro:");
            cor = Console.ReadLine();

            Console.WriteLine("placa do carro:");
            placa = Console.ReadLine();


            Carro carro = new Carro(marca, modelo, cor, placa);



            //cad aluguel
            string kmInicio, cartaoCredito, dataLocacao;

            int taxaAluguel, taxaSeguro;



            Console.WriteLine("km inicial do carro:");
            kmInicio = Console.ReadLine();

            Console.WriteLine("cartao de credito:");
            cartaoCredito = Console.ReadLine();

            Console.WriteLine("data locação:");
            dataLocacao = Console.ReadLine();

            Console.WriteLine("taxa de locação:");
            taxaAluguel = int.Parse(Console.ReadLine());

            Console.WriteLine("taxa de seguro:");
            taxaSeguro = int.Parse(Console.ReadLine());


            Aluguel aluguel = new Aluguel(kmInicio, taxaAluguel, taxaSeguro, cartaoCredito, dataLocacao);
















        }
    }
}