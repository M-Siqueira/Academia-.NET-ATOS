namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p;

            Console.WriteLine("digite um numero");
            p = int.Parse(Console.ReadLine());

          
            if ((p % 2) == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }
        }
    }
}