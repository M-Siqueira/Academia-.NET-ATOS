namespace exemploCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Carro carro = new Carro();

            carro.ligar();

            bool status = carro.getLigado();

            

            if (status)
            {
                Console.WriteLine("carro ligado");
                Console.WriteLine("carro \n");
            }
            else
            {
                Console.WriteLine("carro desligado");
                Console.WriteLine("carro \n");
            }
        }
    }
}