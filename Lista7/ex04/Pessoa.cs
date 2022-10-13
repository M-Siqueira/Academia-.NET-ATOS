using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public string pai;
        public string mae;


        


        public void mostraMae(string mae)
        {
            Console.WriteLine("mae "+ mae);
        }
        public void mostraPai(string pai)
        {
            Console.WriteLine("pai " + pai);
        }

    }
}
