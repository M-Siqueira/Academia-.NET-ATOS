using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    internal class Personagem
    {
        private string _nomePerson;
        private int _poderPerson;


        public Personagem()
        {

        }

        public Personagem(string nome, int poder)
        {
            this._nomePerson = nome;
            this._poderPerson = poder;
        }

        public string NomePerson { get => _nomePerson; set => _nomePerson = value; }
        public int PoderPerson { get => _poderPerson; set => _poderPerson = value; }


        public void ExibeDados (List<string>list, List<int> list2)
        {
            for(int i = 0; i < list.Count; i++)
            {
                int maiorValor = list2.Max();

                if (list2[i] == maiorValor)

                {
                    Console.WriteLine("nome: " + list[i] + "poder: "+ list2[i]);    
                }

              
            }
            



        }

    }
}
