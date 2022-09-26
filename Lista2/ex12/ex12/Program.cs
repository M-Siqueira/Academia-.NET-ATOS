namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod;
            double total, horas,horaT = 10.00, max, extra;

            Console.WriteLine("codigo: ");
            cod = int.Parse(Console.ReadLine());

            Console.WriteLine("numero horas: ");
            horas = double.Parse(Console.ReadLine());

            total = horaT * horas;
            max = 50;

            extra = total - max;


            Console.WriteLine("salario total h trabalhadas: "+total);
            Console.WriteLine("horas maximas possiveis: " + max);
            Console.WriteLine("horas extras feitas: " + extra);
        }
    }
}