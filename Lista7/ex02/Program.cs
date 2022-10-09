using System.Net;

namespace ex02
{
    internal class Program 
    {

        //        2 - Escreva uma classe Pessoa contendo
        //        todos os atributos de uma pessoa.
        //        Faça métodos para apresentar os dados.
        //        Faça a leitura pelo teclado dos atributos
        //        e crie um construtor para fazer o instanciamento.

        static void Main(string[] args)
        {
            string PessoaNome, PessoaSex;
            int Idade;
            double peso, altura;

            Console.WriteLine("digite o nome da pessoa:");
            PessoaNome = Console.ReadLine();

            Console.WriteLine("sexo da pessoa:(M ou F):");
            PessoaSex = Console.ReadLine();

            Console.WriteLine("digite a idade nome da pessoa:");
            Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a altura da pessoa:");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o peso da pessoa:");
            peso = double.Parse(Console.ReadLine());


            Pessoa p = new Pessoa(PessoaNome,PessoaSex,Idade,altura,peso);

            p.exibeDados(PessoaNome,PessoaSex,Idade,altura,peso);

            p.imc(peso, altura);

            

        }
    }
}