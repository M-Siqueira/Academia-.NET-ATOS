using System.Numerics;

namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float entrada;
            int saida,auxiliar,par;
            
            do
            {

                Console.WriteLine("digite um numero inteiro");
                entrada = float.Parse(Console.ReadLine());

                auxiliar = (int)entrada;

                par = auxiliar % 2;

                if ((entrada/1) == auxiliar)
                {
                    
                    Console.WriteLine("é inteiro");
                    if (par == 0)
                    {
                        Console.WriteLine("PAR");
                    }
                    else
                    {
                        Console.WriteLine("IMPAR");
                    }
                }
                if ((entrada/1) != auxiliar)
                {
                    
                    Console.WriteLine("nao é inteiro");
                }


                Console.WriteLine("numero digitado foi : " + entrada);
                Console.WriteLine("\n");
               


            } while ((entrada / 1) != auxiliar);
        }
    }
}
    //var convertido = parseint();