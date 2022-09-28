namespace exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0, par = 0, x, y;

            Console.WriteLine("digite o numero inicial");

            x = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o numero final");

            y = int.Parse(Console.ReadLine());

            for (int i = x; i < y; i++)
            {
                if ((i % 2 != 0) && (x > 0) && (y > 0))
                {
                    par++;
                }
                else if ((i % 2 == 0) && (x > 0) && (y > 0))
                {
                    b += i;
                }

                
            }
            Console.WriteLine("resultado " + par);
            Console.WriteLine("resultado " + b);
        }
    }
}