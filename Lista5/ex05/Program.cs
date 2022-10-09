namespace ex05
{
    //    5) Leia duas matrizes 2x3 de números double. 
    //Imprima a soma destas duas matrizes.

    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 2, y = 3;

            double[,] mat1 = new double[t, y];

            double[,] mat2 = new double[t, y];

            Console.WriteLine("matriz 1:\n");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("linha [" + i + "] coluna [" + j + "].");
                    mat1[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("matriz 2:\n");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("linha [" + i + "] coluna [" + j + "].");
                    mat2[i, j] = double.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("matriz 1: ");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("[" + mat1[i, j] + "] ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("matriz 2: ");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("[" + mat2[i,j] + "] ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("soma das matrizes:");
            for (int i = 0; i < t; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    Console.Write("[" +( mat1[i, j] + mat2[i, j] ) + "] ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}