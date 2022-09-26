namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora, min;

            Console.WriteLine("digite a hora (padrao 24hs): \n");
            hora = int.Parse(Console.ReadLine());

            Console.WriteLine("digite os minutos: \n");
            min = int.Parse(Console.ReadLine());

            if ((hora >= 0 && hora <= 23) && (min >=0 && min <= 59))
            {
                Console.WriteLine("hora valida");
            }
            else
            {
                Console.WriteLine("hora invalida");
            }
            



        }
    }
}