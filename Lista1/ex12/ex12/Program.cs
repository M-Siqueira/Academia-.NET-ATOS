namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, rodado, valor, liquido, autonomia, gas = 6.90;

            Console.WriteLine("odometro inicial: \n");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("odometro final: \n");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("litros gastos: \n");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("valor bruto diario: \n");
            d = double.Parse(Console.ReadLine());

            rodado = b - a;

            valor = c * gas;

            liquido = d - valor;

            autonomia = rodado / c;

            Console.WriteLine(" \n"+ " \n");

            Console.WriteLine("autonomiado veiculo: "+autonomia+"\n");
            Console.WriteLine("lucro liquido do motorista: "+liquido + "\n");


        }
    }
}