using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Carro
    {
        private string marca;
        private string modelo;
        private string cor;
        private string placa;

        public Carro(string marca, string modelo, string cor, string placa)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.placa = placa;

        }
        
        public string getMarca(string cor)
        {
            return this.marca;
        }
        public string getModelo(string cor)
        {
            return this.modelo;
        }
        public string getCor(string cor)
        {
            return this.cor;
        }
        public string getPlaca(string cor)
        {
            return this.placa;
        }




    }
}
