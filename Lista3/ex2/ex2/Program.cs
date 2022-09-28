using System.Runtime.ConstrainedExecution;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
            //informar um outro número. Caso positivo, o programa em VS deve ser repetido.


            //Exemplo:
            //            Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.


            //Deseja informar outro número(s/ n)? S

            //Digite um número inteiro positivo: 12
            //Numero digitado: 20
            //Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.


            //Deseja informar outro número(s/ n)? N

            

            int contA = 0, contB = 0, num, i;
            string R,S,s;

            Console.WriteLine("gostaria de digitar um  numero? (S ou N)");
            R = Console.ReadLine();

            if ( (R == "S") || (R == "s")) {

                do
                {
                    Console.WriteLine("digite um numero \n");
                    num = int.Parse(Console.ReadLine());

                    if (num <= 0)
                    {
                        Console.WriteLine("incorreto " + num);
                    }

                } while (num <= 0);

                Console.Write("Número digitado " + num + "\n\n");
                Console.Write("Números inteiros pares entre 1 a: " + num + ":");

                for (i = 0; i < num; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");

                    }

                }
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("fim do programa sem digitar numeros!!!!"); ;
            }
            
            
        }

    }
}