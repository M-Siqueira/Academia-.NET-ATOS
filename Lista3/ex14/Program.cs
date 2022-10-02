using System.Security.Cryptography.X509Certificates;

namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14.Mostrar as potências de 2 variando de 0 a 10.

            for (int i = 1; i < 11; i++){

                int x = 2;

                double result = Math.Pow(x, i);

                Console.WriteLine("potencia 2 na "+ i + " igual a: "+ result);
            }

        }
    }
}