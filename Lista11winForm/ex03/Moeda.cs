using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Moeda
    {
        public string _sigla;
        public string _name;
        public string _valor;

        public Moeda(string sigla, string nome, string valor)
        {
            this._sigla = sigla;
            this._name = nome;
            this._valor = valor;
        }

    }
}
