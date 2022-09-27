namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura;

            Console.WriteLine("altura: \n");

            altura = double.Parse(Console.ReadLine());

            Console.WriteLine(" \n");

            Console.WriteLine("para homens: "+((72.7*altura)-58));

            Console.WriteLine(" \n");

            Console.WriteLine("para mulheres: " + ((62.1 * altura)-44.7));
        }
    }
}