using System.Xml.Schema;

namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cod, total, sal, percent, vendas; 

            Console.WriteLine("codigo do vendedor: \n");
            cod = int.Parse(Console.ReadLine());

            Console.WriteLine("salario: \n");
            sal = int.Parse(Console.ReadLine());

            Console.WriteLine("vendas: \n");
            vendas = int.Parse(Console.ReadLine());

            Console.WriteLine("percentual extra: \n");
            percent = int.Parse(Console.ReadLine());

            total = sal + ((vendas / 100) * percent);

            Console.WriteLine("vendedor "+cod+" salario final: "+total);
        }
    }
}