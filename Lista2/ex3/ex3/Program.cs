namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d,M;

            Console.WriteLine("digite o primeiro valor: \n");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo valor: \n");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o terceiro valor: \n");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o quarto valor: \n");
            d = int.Parse(Console.ReadLine());


            M = (a + b + c + d) / 4;
            Console.WriteLine(" \n");
            Console.WriteLine("a media é: " + M+" \n");

            if (a>M)
            {
                Console.WriteLine("maior que a media: PRIMEIRO");
            }
            if (b>M)
            {
                Console.WriteLine("maior que a media: SEGUNDO");
            }
            if (c>M)
            {
                Console.WriteLine("maior que a media: TERCEIRO");
            }
            if (d>M)
            {
                Console.WriteLine("maior que a media: QUARTO");
            }



        }
    }
}