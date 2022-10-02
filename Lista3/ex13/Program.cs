using System.Net;

namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13.Elaborar um programa que apresente o somatório dos valores pares existentes
            //entre 1 e 500.


            int soma = 0;

            Console.WriteLine("numeros pares entre 1 e 500: \n");
            for (int i = 1; i < 501; i++)
            {
               
                if ( i %2 == 0)
                {
                    soma += i;

                }
                
            }
            Console.WriteLine("soma dos pares: " + soma);
        
    }
    }
}