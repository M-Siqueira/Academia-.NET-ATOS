namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float b, a, r;

            Console.WriteLine("digite o valor de base do triangulo: \n");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor de altura do triangulo: \n");
            a = float.Parse(Console.ReadLine());

            if (b == 0 || a == 0)
            {
                Console.WriteLine("nao é um triangulo \n");
            }
            else
            {
                Console.WriteLine("area: " + (r = (b * a) / 2));
            }
        }
    }
}