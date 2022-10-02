using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa.
            //A cada solicitação, teste se o usuário informou um valor válido. 
            //Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            //informe que ele está incorreto e saia do programa em VS.
            //Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero),
            //informe que está errada e saia.Se estiver correta, solicite o salário.
            //Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.
            //Se estiver correto, mostre todos os valores lidos.



            int idade, n;
            string nome;
            double salario;
            bool m;

            Console.WriteLine("digite seu nome\n");
            nome = Console.ReadLine();
            Console.WriteLine("\n");

            bool isNumeric = int.TryParse(nome, out n);
            m = isNumeric;

            if ((m == true))
            {
                Console.WriteLine("erro ao digitar");
                return;
            }

            Console.WriteLine("digite sua idade\n");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if (idade < 0)
            {
                Console.WriteLine("erro ao digitar");
                return;
            }

            Console.WriteLine("digite seu salario\n");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if (salario < 0)
            {
                Console.WriteLine("erro ao digitar");
                return;
            }

            Console.WriteLine("seu nome e: " + nome);
            Console.WriteLine("sua idade e " + idade);
            Console.WriteLine("seu salario e: " + salario);





            //




        }

    }
}