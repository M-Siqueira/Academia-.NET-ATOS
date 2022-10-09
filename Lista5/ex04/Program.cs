using System.Reflection;

namespace ex04
{
    internal class Program
    {
        //        4) Popule uma matriz 5x5 e informe:
        //-Quantos números são pares
        //-Quantos números são impares
        //-Quantos números são positivos
        //-Quantos números são negativos
        //-Quantos zeros existem!

        static void Main(string[] args)
        {
            int t = 5,par = 0,impar = 0,zero = 0,negativo = 0,positivo = 0;
            int[,] mat = new int[t, t];


            for(int i = 0; i < t; i++)
            {
                for(int j = 0; j < t; j++)
                {
                    Console.WriteLine("linha ["+i+"] coluna ["+j+"].");
                    mat[i,j] = int.Parse(Console.ReadLine());

                    if(mat[i,j] >= 0)
                    {
                        

                        if (mat[i, j] % 2 == 0)
                        {
                            if (mat[i, j] == 0)
                            {
                                zero++;
                            }
                            par++;
                        }
                        if(mat[i, j] %2 != 0)
                        {
                            impar++;
                        }
                        if (mat[i,j] > 0)
                        {
                            positivo++;
                        }
                    }
                    else
                    {
                        if (mat[i, j] % 2 == 0)
                        {
                            par++;
                        }
                        if (mat[i, j] % 2 != 0)
                        {
                            impar++;
                        }
                        negativo++;
                    }


                }
            }

            Console.WriteLine("pares: "+par);
            Console.WriteLine("impares: " + impar);
            Console.WriteLine("positivos: " + positivo);
            Console.WriteLine("negativo: " + negativo);
            Console.WriteLine("zero: " + zero);






        }
    }
}