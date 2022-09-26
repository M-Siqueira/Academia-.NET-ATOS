using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d, e,f,g;

            Console.WriteLine("numero eleitores do municipio:\n");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("numero de votos validos:\n");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("numero de votos nulos\n");
            c = float.Parse(Console.ReadLine());

            Console.WriteLine("numero de votos brancos:\n");
            d = float.Parse(Console.ReadLine());

            
           e = (100 * b) / a ;
           f = (100 * c) / a;
           g = (100 * d) / a;


            Console.WriteLine( Math.Round( e , 2 ));

            Console.WriteLine( Math.Round( f , 2 ));

            Console.WriteLine( Math.Round( g , 2 ));


        }
    }
}



