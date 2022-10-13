using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    internal class Animal
    {
        protected string nome;
        protected string sexo;
        protected string raca;

        public Animal(string nome, string sexo, string raca)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.raca = raca;
        }

        public void EmitirSom()
        {
            Console.WriteLine("emitindo som...");
        }
        public void Dormir()
        {
            Console.WriteLine("dormindo...");
        }
        public void Caminhar()
        {
            Console.WriteLine("caminhando...");
        }

        public void MostraDados(string nome, string sexo, string raca,int peso)
        {
            Console.WriteLine("nome: "+nome+" sexo: "+ sexo+" raça: "+raca+" peso: "+peso);
        }

    }
}
