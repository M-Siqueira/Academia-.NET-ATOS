using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Aluguel
    {
        
        private int taxaAluguel;
        private int taxaSeguro;
        private string dataLocacao;
        private Carro carro;
        private Cliente cliente;



        public Aluguel( int taxaAluguel, int taxaSeguro,string dataLocacao,Carro carro, Cliente cliente)
        {
            this.taxaAluguel = taxaAluguel;
            this.taxaSeguro = taxaSeguro;
            this.dataLocacao = dataLocacao;
            this.carro = carro;  
            this.cliente = cliente;

        }
    }
}
