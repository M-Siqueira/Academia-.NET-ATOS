using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    internal class Aluno : Pessoa
    {

        private string _matricula;
        private string _codCurso;
        private string _nomeCurso;
        private string _indicaCurso;

        public string Matricula { get => _matricula;  set => _matricula = value; }

        public string CodCurso { get => _codCurso;  set => _codCurso = value; }

        public string NomeCurso { get => _nomeCurso;  set => _nomeCurso = value; }

        public string IndicaCurso { get => _indicaCurso; set => _indicaCurso = value; }



        public Aluno(string indicaLinha, string nome, string telefone, string cidade, string rg, string cpf, string indicacurso, string matricula, string codcurso, string nomecurso) : base(indicaLinha, nome, telefone, cidade, rg, cpf)
        {

            this.IndicadorLinha = indicaLinha;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cidade = cidade;
            this.Rg = rg;
            this.Cpf = cpf;
            this._indicaCurso = indicacurso;
            this._matricula = matricula;
            this._codCurso = codcurso;
            this._nomeCurso = nomecurso;

        }

          
        










    }



}
