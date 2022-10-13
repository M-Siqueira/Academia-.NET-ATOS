using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronico
{
    abstract class Eletronico
    {
        private int volts;
        private int _potencia;
        private bool _ligado;

        public int Volts { get => volts; set => volts = value; }
        public int Potencia { get => _potencia; set => _potencia = value; }
        public bool Ligado { get => _ligado; set => _ligado = value; }

        public abstract void Ligar();


        public void Desligar()
        {
            Console.WriteLine("desligando......('-')");
            _ligado = false;
        }

        //public bool VerificaLigado()
        //{
        //    return _ligado;
        //}




    }
}
