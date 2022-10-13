using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooPessoa
{
    internal class Pessoa
    {
        public Pessoa()
        {

        }
        public string Nome { get; set; }
        public int Idade { get; set; } 

        public Pessoa(int idade, string nome)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        

    }
}
