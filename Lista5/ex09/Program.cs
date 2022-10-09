using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ex09
{
    internal class Program
    {

        //        9) Leia uma matriz 3x3.Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.
        //Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

        static void Main(string[] args)
        {
            int t = 4, opcao;
            int[,] matriz = new int[t, t];
            int cont = 0;


            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.WriteLine("valor da matriz: \n");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine("qual numero deseja buscar? \n");
            opcao = int.Parse(Console.ReadLine());


            for (int i = 0; i < t; i++)
            {
               
                for (int j = 0; j < t; j++)
                {


                    if (opcao == matriz[i, j])
                    {
                        Console.WriteLine("existe no vetor");
                        break;
                    }
                    cont++;
                    if(cont == t*t)
                    {
                        Console.WriteLine("numero  inexistente");
                        //Console.WriteLine(cont); teste de contagens 
                        break;
                    }

                }

            }





        }
    }
}