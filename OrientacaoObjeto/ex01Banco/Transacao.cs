using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01Banco
{
    internal class Transacao
    {
        double saldo;

        private string agencia;
        private int tipo;
        private double valor;
        private string conta;

        public Transacao(string agencia, int tipo, double valor, string conta)
        {

            this.agencia = agencia;
            this.tipo = tipo;
            this.valor = valor;
            this.conta = conta;

        }

        public void depositar(double deposito)
        {
           // valor = valor + 100;
            Console.WriteLine("deposito");

        }

        public void saque(double saque)
        {
            valor = (valor - saque);
            Console.WriteLine("saldo restante: "+valor);

        }

        public void consultarSaldo()
        {
            Console.WriteLine("saldo é " + valor);
        }

        public void exibeDados()
        {
            Console.WriteLine("agencia " + agencia);
            Console.WriteLine("Conta " + conta);
            Console.WriteLine("tipo " + tipo);
            Console.WriteLine("valor " + valor);

        }



    }
}
