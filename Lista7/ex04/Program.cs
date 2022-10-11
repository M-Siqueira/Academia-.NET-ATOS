using System.Runtime.CompilerServices;

namespace ex04
{
    internal class Program
    {

        // 4 - Faça um programa que represente a arvore genealógica da tua familia.
        // Para isso, uma classe Pessoa precisa ser indicar quem são seus pais, alem deinformações básicas sobre a pessoa.

        static void Main(string[] args)
        {
            string nome, pai, mae;
            int idade;

            Console.WriteLine("nome:");
            nome = Console.ReadLine();

            Console.WriteLine("idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("nome do pai:");
            pai = Console.ReadLine();

            Console.WriteLine("nome da mae:");
            mae = Console.ReadLine();

            Pessoa pAvo = new Pessoa(nome, idade, pai, mae);

            pAvo.getNome(nome);
            pAvo.getIdade(idade); ;
            pAvo.getPai(pai);
            pAvo.getMae(mae);



            //===========================================================
            Console.WriteLine("nome:");
            nome = Console.ReadLine();

            Console.WriteLine("idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("nome do pai:");
            pai = Console.ReadLine();

            Console.WriteLine("nome da mae:");
            mae = Console.ReadLine();

            Pessoa pPai = new Pessoa(nome, idade, pai, mae);

            pPai.getNome(nome);
            pPai.getIdade(idade); ;
            pPai.getPai(pai);
            pPai.getMae(mae);


            //===========================================================

            Console.WriteLine("nome:");
            nome = Console.ReadLine();

            Console.WriteLine("idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("nome do pai:");
            pai = Console.ReadLine();

            Console.WriteLine("nome da mae:");
            mae = Console.ReadLine();

            Pessoa filho = new Pessoa(nome, idade, pai, mae);

            filho.getNome(nome);
            filho.getIdade(idade); ;
            filho.getPai(pai);
            filho.getMae(mae);

            //=======================================================        

            filho.mostraMae(mae);
            pPai.mostraMae(mae);
            pAvo.mostraMae(mae);


        }
    }
}