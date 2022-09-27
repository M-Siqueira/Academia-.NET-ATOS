namespace ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Random num = new Random();
            x = num.Next(0, 100);

            Console.WriteLine(x);
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("advinhe o numero");
                y = int.Parse(Console.ReadLine());


                if (x == y)
                {
                    Console.WriteLine("paracbens vc avcertou");
                }
                if (x > y)
                {
                    Console.WriteLine("errou, o numero é maior.");
                }
                if (x < y)
                {
                    Console.WriteLine("errou, o numero é menor.");
                }
            }
            Console.WriteLine("fim");


        }
    }
}