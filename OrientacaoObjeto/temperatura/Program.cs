namespace temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite uma temperatura em FH");

            Temp temp = new Temp();

            temp.setCelsius(double.Parse(Console.ReadLine()));


        }
    }
}