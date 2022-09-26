namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float consumo, k, l;

            Console.WriteLine("quantos km o carro andou? ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("quantos litros de combustivel utilizou para percorrer ");
            l = int.Parse(Console.ReadLine());

            consumo = k / l;

            Console.WriteLine("consumo é: "+consumo+" km/l");    
        }

    }
}