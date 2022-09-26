using System.Reflection.Metadata;
using System.Xml.Serialization;
namespace ex4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int d,m,a;

            
            Console.WriteLine("coloque o dia: ");

            d = int.Parse(Console.ReadLine());

            Console.WriteLine("coloque o mes: ");

            m = int.Parse(Console.ReadLine());

            Console.WriteLine("coloque o ano: ");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine(""+ d+"" + m+"" + a);

            Console.WriteLine("" + m + "" + d + "" + a);

           // Console.WriteLine("" + d + "" + m + "" + a);



        }
    }
}
