namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeA, timeB, saldo;

            Console.WriteLine("placar time da casa: \n");
            timeA = int.Parse(Console.ReadLine());

            Console.WriteLine("placar time visitante: \n");
            timeB = int.Parse(Console.ReadLine());

            Console.WriteLine("time da casa: "+timeA+" X "+timeB+" time visitante.");

            Console.WriteLine("\n");


            if (timeB >= (timeA + 2))
            {
                Console.WriteLine("time visitante Classificado.");
            }
            else
            {
                Console.WriteLine("novo jogo entre times.");

                Console.WriteLine("\n");

                Console.WriteLine("placar time da casa: \n");
                timeA = int.Parse(Console.ReadLine());

                Console.WriteLine("placar time visitante: \n");
                timeB = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                Console.WriteLine("time da casa: " + timeA + " X " + timeB + " time visitante.");

                if (timeA > timeB)
                {
                    Console.WriteLine("vitoria da casa");
                }
                else
                {
                    Console.WriteLine("vitoria dos visitantes");
                }
            }
        }
    }
}