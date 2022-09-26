namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, Media, exame, Final;

            Console.WriteLine("nota 1 do aluno: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("nota 2 do aluno: ");
            n2 = double.Parse(Console.ReadLine());

            Media = (n1 + n2) / 2;

            if (Media >= 7)
            {
                Console.WriteLine("aprovado");
            }
            else
            {
                Console.WriteLine("insira a nora do exame: ");
                exame = double.Parse(Console.ReadLine());

                Final = (Media + exame) / 2;
                if (Final >= 5)
                {
                    Console.WriteLine("aprovado no exame");
                }
                else
                {
                    Console.WriteLine("reprovado");
                }
                

            }
        }
    }
}