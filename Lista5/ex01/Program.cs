using System.Data.Common;

namespace ex01
{
    internal class Program
    {       //1) Crie uma Matriz 5x3.Na primeira coluna, solicite que o usuário preencha.
            //A 2ª coluna, some 10 aos elementos da 1ª coluna.
            //Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.


        static void Main(string[] args)
        {
            int[,] mat = new int[5, 3];


            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("inserir valor da coluna:");
                mat[j, 0] = int.Parse(Console.ReadLine());

                mat[j, 1] = mat[j, 0] + 10;

                mat[j, 2] = mat[j, 1] * 2;

            }
           
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("[" + mat[j, 0]+ "] [" + mat[j, 1]+ "] ["+mat[j, 2]+"]");
                //Console.WriteLine("coluna 2: " + mat[j, 1]);
                //Console.WriteLine("coluna 3: " + mat[j, 2]);
            }



        }
    }
}