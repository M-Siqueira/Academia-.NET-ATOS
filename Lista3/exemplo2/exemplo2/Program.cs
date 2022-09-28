namespace exemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numDigitado = 0, pares = 0;

            do
            {
                Console.WriteLine("digite um numero");
                numDigitado = int.Parse(Console.ReadLine());

                if (numDigitado % 2 == 0)
                {
                    pares++;
                }

            } while (numDigitado > 0 || (numDigitado % 2 == 0));
            Console.WriteLine("pares digitados "+pares);
        }
    }
}