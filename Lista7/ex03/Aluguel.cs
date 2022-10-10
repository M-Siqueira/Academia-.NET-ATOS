using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Aluguel
    {
        private string kmInicio;
        private int taxaAluguel;
        private int taxaSeguro;
        private string cartaoCredito;
        private string dataLocacao;

        public Aluguel(string kmInicio, int taxaAluguel, int taxaSeguro, string cartaoCredito,string dataLocacao)
        {
            this.kmInicio = kmInicio;
            this.taxaAluguel = taxaAluguel;
            this.taxaSeguro = taxaSeguro;
            this.cartaoCredito = cartaoCredito;
            this.dataLocacao = dataLocacao;

        }
    }
}
