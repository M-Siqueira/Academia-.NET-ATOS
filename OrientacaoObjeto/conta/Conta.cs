using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta
{
    internal class Conta
    {
        public Cliente cliente;
        private double saldo;
        public string tipo = "corrente";

        public Conta(Cliente cliente, double saldo, string tipo)
        {
            this.cliente = cliente;
            this.saldo = saldo;
            this.tipo = tipo;
        }

        public void deposito(double valor)
        {
            saldo += valor;
            Console.WriteLine("deposito  efetuadp"+saldo);
        }

        public void saque(double valor)
        {
            saldo -= valor;
            Console.WriteLine("saqwue efetuadp"+saldo);
        }

        public double getSaldo()
        {
            return saldo;
            Console.WriteLine("saldo em conta: "+ saldo);
        }

       

    }
}
