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
            this._indicadorLinha = indicaLinha;
            this._nome = nome;
            this._telefone = telefone;
            this._cidade = cidade;
            this._rg = rg;
            this._cpf = cpf;

        }

        public static void buscaDados(List<string> listaAlunos, List<string> listaCompleta )
        {

           //Aluno a1 = new Aluno();

        }
    }
}
