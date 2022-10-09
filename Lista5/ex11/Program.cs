using System.Net;

namespace ex11
{
    internal class Program
    {

        //11) Leia uma matriz A de tipo double de dimenção 3x3,
        //crie uma nova matriz resultante da divisão dos elementos
        //da matriz A pela soma dos seus indices.
        static void Main(string[] args)
        {
            int t = 3;
            double[,] A = new double[t, t];
            double[,] resultante = new double[t, t];

            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.WriteLine("valor linha [" + i + "] coluna [" + j + "] ");
                    A[i, j] = double.Parse(Console.ReadLine());

                }
            }


            Console.WriteLine("matriz:\n");

            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {


                    Console.Write("[" + A[i,j]+"] ");

                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n");
            Console.WriteLine("resultante:\n");

            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {

                    resultante[i, j] =( (A[i, j]) / (i + j) );

                    Console.Write("[" + resultante[i,j]+"] ");

                }
                Console.WriteLine("\n");
            }
        }
    }
}