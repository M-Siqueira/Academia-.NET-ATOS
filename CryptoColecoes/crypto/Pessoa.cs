using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto
{
    internal class Pessoa
    {

        public string Cpf { get; set; }
        public string Nome { get; set; }

        public DateOnly DataNascimento { get; set; }

        public Pessoa(string nome, string cpf, DateOnly dataN)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataNascimento = dataN;
        }

        public override string ToString()
        {
            return "nome "+ Nome + "cpf " + Cpf + "data nascimento "+ DataNascimento;
        }

        public override bool Equals(object? obj)
        {
            return obj is Pessoa pessoa && Cpf == pessoa.Cpf;
        }

        public int CompareTo(object? obj)
        {
            Pessoa p = (Pessoa)obj;
            if(this.Nome == p.Nome)
            {
                return 0;

            }else if (this.Nome.CompareTo(p.Nome) < 0)
            {
                return -1;
            }

            return 0;
        }
    }
}
