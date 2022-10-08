using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criaClasse
{
    internal class lampada
    {
        private bool ligado;
        private double potencia;
        public int teste;
        public void ligar()
        {
            ligado = true;
            Console.WriteLine("ligando lampada");
            Console.Beep();
        }
        public void desligar()
        {
            ligado = false;

            Console.WriteLine("desligando lampada");

            Console.Beep();
        }

        public bool estaLigada()
        {
            return ligado;
        }


    }
}
