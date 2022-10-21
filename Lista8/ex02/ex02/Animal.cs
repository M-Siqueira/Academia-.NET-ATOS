using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Animal
    {
        private string _raça;
        private string _nome;

        public string Raça { get => _raça; set => _raça = value; }

        public string Nome { get => _nome; set => _nome = value; }


        public Animal(string raca, string nome)
        {
            this._raça = raca;
            this._nome = nome;  
        }

        public void adicinaAnimal(string nome, string tipo)
        {
           
        }




    }
}
