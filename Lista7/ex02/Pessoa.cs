using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Pessoa
    {
        private string PessoaNome;
        private string PessoaSex;
        private int Idade;
        private double altura;
        private double peso;

        public Pessoa(string PessoaNome, string PessoaSex, int Idade, double altura, double peso)
        {

            this.PessoaNome = PessoaNome;
            this.PessoaSex = PessoaSex;
            this.Idade = Idade;
            this.altura = altura;
            this.peso = peso;
        }

        public void exibeDados(string PessoaNome, string PessoaSex, int Idade, double altura, double peso)
        {


            Console.WriteLine(PessoaNome);
            Console.WriteLine(PessoaSex);
            Console.WriteLine(Idade);
            Console.WriteLine(altura);
            Console.WriteLine(peso);


        }

        public void imc(double peso, double altura)
        {

            double valor = (peso) / (altura * altura);


            Console.WriteLine("o IMC da pessoa em questao é: "+ valor);
        }

    }

}
