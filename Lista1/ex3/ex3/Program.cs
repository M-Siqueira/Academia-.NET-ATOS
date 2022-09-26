namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y,c,d;

            Console.WriteLine("insira o valor de A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o valor de B:");
            b = int.Parse(Console.ReadLine());

            x = a;
            y = b;
            
            c = y;
            d = x;

            Console.WriteLine("valor inicial de A: "+a);

            Console.WriteLine("valor inicial de B: "+b);

            Console.WriteLine("valor novo de A: "+c);

            Console.WriteLine("valor novo de B: "+d);

           

        }
    }
}