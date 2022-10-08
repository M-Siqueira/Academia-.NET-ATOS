using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploCarro
{
    internal class Carro
    {
        private string placa;
        private string fabricante;

        public bool ligado = false;
        private double velocidade;
        private string modelo;
        private string cor;

        public string Placa { get => placa; set => placa = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public double Velocidade { get => velocidade; set => velocidade = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }

        //public string Modelo { get => modelo; set => modelo = value; } forma de get e set

        //public double Velocidade { get => velocidade; set => velocidade = value; } forma de get e set


        public bool getLigado()
        {
            return ligado;
        }

        public Carro()
        {
            //cuidar letra maiusculaao gerar get and set automatico. 

            this.Velocidade = Velocidade;
            this.Modelo = Modelo;
            this.Cor = Cor;
            this.Placa = Placa;
            this.ligado = ligado;
        }

        public void ligar()
        {
            ligado = true;
        }

        public void desligar()
        {
            ligado = false;
        }


    }
}
