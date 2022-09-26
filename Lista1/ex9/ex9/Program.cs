namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a,b,c,d;

            //a valor total
            //b valor da parcelo convertido para arredondamento
            //c valor da soma das duas parcelas para poder subtrair do total e obter o valor da entrada.

            Console.WriteLine("qual valor do produto: ");
            a = float.Parse(Console.ReadLine());

            b = Convert.ToInt32(a / 3);

            c = b * 2;

            d = a - c;

            Console.WriteLine("\n");
            Console.WriteLine("entrada: "+d+"\n");
            Console.WriteLine("2 parcelas de: " + b + "\n");
        }
    }
}