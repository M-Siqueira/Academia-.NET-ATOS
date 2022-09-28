using System.ComponentModel;
using System.Drawing;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados
            //(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

            //Exemplo:
            //            Digite um número inteiro positivo: -8
            //Valor incorreto!
            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.

            int contA = 0, contB = 0, num, i;

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

        //solução do professor em aula.
    }
}
