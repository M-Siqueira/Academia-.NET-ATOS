namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod;
            float salario,totVendas, parte,totGeral;
            string nome;

            Console.WriteLine("codigo Vendedor: \n");
            cod = int.Parse(Console.ReadLine());

            Console.WriteLine("nome do Vendedor: \n");
            nome = Console.ReadLine();

            Console.WriteLine("salario do Vendedor: \n");
            salario = int.Parse(Console.ReadLine());

            Console.WriteLine("total de vendas  Vendedor: \n");
            totVendas = int.Parse(Console.ReadLine());

            parte = (totVendas / 100);

            if (totVendas > 500 && totVendas < 1000)
            {
                totGeral = (totVendas + (parte * 5));
                Console.WriteLine("salario final do vendedor: "+nome+ ": "+totGeral);

            }else if (totVendas > 1000 && totVendas < 5000)
            {
                totGeral = (totVendas + (parte * 7));
                Console.WriteLine("salario final do vendedor: "+nome+ ": "+totGeral);
            }
            else if (totVendas > 5000)
            {
                totGeral = (totVendas + (parte * 10));
                Console.WriteLine("salario final do vendedor: "+nome+ ": "+totGeral);
            }
        }
    }
}