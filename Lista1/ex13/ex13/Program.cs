namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double custoBike, minimo,nVendas, extra, salarioFinal;

            Console.WriteLine("custo da bicicleta: \n");
           custoBike =  double.Parse(Console.ReadLine());

            Console.WriteLine("salario minimo: \n");
            minimo = double.Parse(Console.ReadLine());

            Console.WriteLine("numero de vendas: \n");
            nVendas = double.Parse(Console.ReadLine());

            extra = nVendas * ((custoBike / 100) * 15);

            salarioFinal = minimo + extra;

            Console.WriteLine("salario final do funcionario: " + salarioFinal + " ja com comissao.");
        }
    }
}