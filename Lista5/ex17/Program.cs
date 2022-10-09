using System.Xml.Linq;

namespace ex17
{
    internal class Program
    {   
        //17) Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas
        //e escreva o elemento minimax, ou seja,o menor elemento da linha
        //onde se encontra o
        //maior elemento da matriz.
        //Escreva também a linha e a coluna onde foi encontrado.

        static void Main(string[] args)
        {
            int t = 3,pLInha=0,pColuna=0,auxMax = 0;
            int[,] mat = new int[t, t];

            for(int i = 0; i < t; i++)
            {
                for(int j = 0; j < t; j++)
                {
                    Console.WriteLine("ler a matriz linha ["+i+"] coluna: ["+j+"] ");
                    mat[i,j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("matriz lida: ");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                { 
                    Console.Write("["+mat[i,j]+"] ");
                }
                Console.WriteLine("\n");
            }


            //minimo da linha e maximo com posicao
            Console.WriteLine("minimo da linha: ");

            for (int i = 0; i < t; i++)
            {
                int minimo = 100000;
                int maximo = 0;
                
                for (int j = 0; j < t; j++)
                {
                    if(mat[i,j] < minimo)
                    {
                        minimo = mat[i,j];
                    }
                    if (mat[i, j] > maximo)
                    {
                        maximo = mat[i, j];
                        auxMax = maximo;
                        pLInha = i;
                        pColuna = j;
                    }

                }


                Console.WriteLine("\n");
                Console.WriteLine("minimo linha ["+i+"]:"+minimo);
            }

            Console.WriteLine("maximno valor da matriz:");
            Console.WriteLine("numero "+auxMax+" posicao linha ["+pLInha+"] coluna ["+pColuna+"] ");



        }
    }
}