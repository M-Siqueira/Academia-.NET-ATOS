using System.Text.RegularExpressions;

namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double area,NumLata;

            Console.WriteLine("em M² qual tamanho da parede a ser pintada? \n");
            area = double.Parse(Console.ReadLine());

            //1 lata = 54m² 80$

            NumLata = Math.Ceiling(area/54);

            Console.WriteLine("voce precisa de "+NumLata+" latas de tinta!");


        }
    }
}