using System.Reflection;

namespace ex02
{
    internal class Program
    {
        //        2. Fazer um programa em VS que popule uma lista com números inteiros(0 a 1000) que sejam sorteados
        //randomicamente.
        //O programa deve pedir ao usuário quantos números deseja armazenar.
        //Ao final, o programa
        //deve exibir os números populados na lista.
        static void Main(string[] args)
        {
            
            List<int> list = new List<int>();

            Random gerador = new Random();

            int qtdArmazena;

            Console.WriteLine("quantos numeros deseja armazenar? \n");
            qtdArmazena = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtdArmazena; i++)
            {
                int numero = gerador.Next(0, 1000);
                list.Add(numero);
            }

            foreach(int numero in list)
            {
                Console.WriteLine(numero);
            }

        }
    }
}