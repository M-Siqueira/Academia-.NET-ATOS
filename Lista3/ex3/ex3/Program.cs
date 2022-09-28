using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
            //Se o usuário digitar 0 o programa em VS deve parar. 
            //Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.


            int num,i,b,j;

            do { 

                Console.WriteLine("digite um numero: \n");
                num = int.Parse(Console.ReadLine());
                if (num %2 == 0)
                {
                    Console.WriteLine("par");
                }
                if(num %2 != 0)
                {
                    Console.WriteLine("impar");
                }



                



            } while (num != 0);


        }


    }
}