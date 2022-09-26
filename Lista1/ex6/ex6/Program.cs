using System.Xml.Schema;

namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float codA, codB, qtdA, qtdB, valorA, valorB,ipiA,ipiB,totalA,totalB,Aipi,Bipi;

            Console.WriteLine("parafuso A:\n ");

            Console.WriteLine("codigo: ");
            codA = int.Parse(Console.ReadLine());
            Console.WriteLine("quantidade: ");
            qtdA = int.Parse(Console.ReadLine());
            Console.WriteLine("valor: ");
            valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("ipi: ");
            ipiA = int.Parse(Console.ReadLine());

            Console.WriteLine("parafuso B:\n ");

            Console.WriteLine("codigo: ");
            codB = int.Parse(Console.ReadLine());
            Console.WriteLine("quantidade: ");
            qtdB = int.Parse(Console.ReadLine());
            Console.WriteLine("valor: ");
            valorB = int.Parse(Console.ReadLine());
            Console.WriteLine("ipi: ");
            ipiB = int.Parse(Console.ReadLine());

            totalA = (qtdA * valorA);
            totalB = (qtdB * valorB);

            Aipi = totalA + ((totalA/100)*ipiA);

            Bipi = totalB + ((totalB/100)*ipiB);
            
            Console.WriteLine(Aipi);
            Console.WriteLine(Bipi);

        }
    }
}