namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float c, F;

            Console.WriteLine("diga a temperatura em celcius: ");
            c = int.Parse(Console.ReadLine());

            F = (9 * c + 160) / 5;

            Console.WriteLine("a temperatura convertida em FAHRENHEIT é: "+F+" !!!");

        }
    }
}
