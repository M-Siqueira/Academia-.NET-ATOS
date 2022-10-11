using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private string pai;
        private string mae;


        public Pessoa(string nome, int idade, string pai, string mae)
        {
            this.nome = nome;
            this.idade = idade;
            this.pai = pai;
            this.mae = mae;
        }

        public void getNome(string nome)
        {
            this.nome = nome;
        }
        public void setNome()
        {

        }
        public void getIdade(int idade)
        {
            this.idade = idade;
        }
        public void setIdade()
        {

        }
        public void getPai(string pai)
        {
            this.pai = pai;
        }
        public void setPai()
        {

        }
        public void getMae(string mae)
        {
            this.mae = mae;
        }
        public void setMae()
        {

        }


        public void mostraMae(string mae)
        {
            Console.WriteLine("mae "+ mae);
        }
        public void mostraPai(string mae)
        {
            Console.WriteLine("mae " + mae);
        }

    }
}
