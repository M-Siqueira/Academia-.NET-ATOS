using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    internal class Pessoa
    {
        private string _indicadorLinha;
        private string _nome;
        private string _telefone;
        private string _cidade;
        private string _rg;
        private string _cpf;

        public string IndicadorLinha { get => _indicadorLinha; set => _indicadorLinha = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }

        public Pessoa(string indicaLinha, string nome, string telefone, string cidade, string rg, string cpf)
        {

        }
    }
}
