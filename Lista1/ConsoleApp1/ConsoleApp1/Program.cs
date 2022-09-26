namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;


            Console.WriteLine("primeiro numero .....");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("segundo numero .....");
            b = int.Parse(Console.ReadLine());

            c = (a + b) / 2;

            Console.WriteLine("resultado"+c);


        }
    }
}