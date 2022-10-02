using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;

namespace ex16
{
    internal class Program
    {
        //        16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da
        //multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
        //(N*3; N*3*3; N*3*3*3; etc).
        static void Main(string[] args)
        {
            double N, cont = 0;
            double prod = 0,aux = 0;

            while (cont < 51)
            {
                Console.WriteLine("digite o numero: ");
                N = int.Parse(Console.ReadLine());
                cont = N;

                if (cont < 51)
                {

                    while(N < 250)
                    {


                        Console.WriteLine("resultado: " + N);

                        prod = N * 3;

                            aux = prod;

                            N = aux;

                        

                    }

                    
                }
            }


            {

            }
        }
    }
}