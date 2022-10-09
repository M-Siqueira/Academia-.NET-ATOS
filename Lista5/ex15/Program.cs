namespace ex15
{
    internal class Program
    {

        //15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.


        static void Main(string[] args)
        {
            int t = 4;
            int[,] A = new int[t, t];
            int[,] B = new int[t, t];
            int[,] resultante = new int[t, t];

            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.WriteLine("complete a matriz A:");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.WriteLine("complete a matriz B:");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("mat resultante: \n");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    resultante[i,j] = A[i,j] + B[i,j];
                    Console.Write("[" + resultante[i,j]+"] ");
                }
                Console.WriteLine("\n");
            }

        }
    }
}