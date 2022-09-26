namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, v3;

            Console.WriteLine("valor glicemico 1: \n");
            v1 = int.Parse(Console.ReadLine());

            if (v1 < 65)
            {
                Console.WriteLine("risco de hipoglicemia");
            }
            if (v1 > 250)
            {
                Console.WriteLine("risco de hiperglicemia");
            }

            Console.WriteLine("valor glicemico 2: \n");
            v2 = int.Parse(Console.ReadLine());

            if (v2 < 65)
            {
                Console.WriteLine("risco de hipoglicemia");
            }
            if (v2 > 250)
            {
                Console.WriteLine("risco de hiperglicemia");
            }

            Console.WriteLine("valor glicemico 3: \n");
            v3 = int.Parse(Console.ReadLine());

            if (v3 < 65)
            {
                Console.WriteLine("risco de hipoglicemia");
            }
            if (v3 > 250)
            {
                Console.WriteLine("risco de hiperglicemia");
            }

        }
    }
}