using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    internal class Aluno : Pessoa
    {
        private string _indicadorCurso { get => _indicadorCurso; set => _indicadorCurso = value; }
        private string _matricula { get => _matricula; set => _matricula = value; }
        private string _codCurso { get => _codCurso; set => _codCurso = value; }
        private string _nomeCurso { get => _nomeCurso; set => _nomeCurso = value; }


        public Aluno(string indicaLinha, string nome, string telefone, string cidade, string rg, string cpf, string indicacurso, string matricula, string codcurso, string nomecurso) : base(indicaLinha, nome, telefone, cidade, rg, cpf)
        {
            this.IndicadorLinha = indicaLinha;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cidade = cidade;
            this.Rg = rg;
            this.Cpf = cpf;

        }
    }
}
