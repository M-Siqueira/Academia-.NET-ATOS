using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    internal class Leao : Animal
    {
        int peso;

        public Leao(string nome, string sexo, string raca,int peso) : base(nome, sexo, raca)
        {
            this.peso = peso;

        }

        public void EmitirSom()
        {
            Console.WriteLine("leao berrando......");
        }

        public void Peso(int peso)
        {
            Console.WriteLine("leao peso......"+peso);
        }


    }
}
