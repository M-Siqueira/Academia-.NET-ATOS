using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeA, nomeB;
            int idadeA, idadeB;
            float alturaA, alturaB;
            double alto,velho;

            Console.WriteLine("nome do atleta A: ");
            nomeA = Console.ReadLine();

            Console.WriteLine("idade do atleta A: ");
            idadeA = int.Parse(Console.ReadLine());

            Console.WriteLine("altura do atleta A: ");
            alturaA = float.Parse(Console.ReadLine());

            Console.WriteLine("nome do atleta B: ");
            nomeB = Console.ReadLine();

            Console.WriteLine("idade do atleta B: ");
            idadeB = int.Parse(Console.ReadLine());

            Console.WriteLine("altura do atleta B: ");
            alturaB = float.Parse(Console.ReadLine());

            
            alto = (alturaA - alturaB);

            

            if (alto < 0)
            {
                Console.WriteLine("b mais alto");
            }
            else
            {
                Console.WriteLine("a mais alto");
            }

            velho = (idadeA - idadeB);

            if (velho < 0)
            {
                Console.WriteLine("b mais velho");
            }
            else
            {
                Console.WriteLine("a mais velho");
            }


        }
    }
}