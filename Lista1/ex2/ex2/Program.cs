using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a,b,c,d,e;

            Console.WriteLine("primeiro numero .....");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("segundo numero .....");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("terceiro numero .....");
            c = float.Parse(Console.ReadLine());

            Console.WriteLine("querto numero .....");
            d = float.Parse(Console.ReadLine());

            e = (a+b+c+d)/4;

            Console.WriteLine("resultado: "+" "+e );
        }
    }
}