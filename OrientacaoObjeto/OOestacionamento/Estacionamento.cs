using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOestacionamento
{
     class Estacionamento
    {
        public List<Carro> carros = new List<Carro>();
        public string nome;

        

        public Estacionamento(string nome)
        {
            this.nome = nome;
           
        }

        public void inicializaEstacionamento(string marca, string modelo, string placa)
        {
            Carro c = new Carro(marca, modelo, placa);

            c.marca = "vazio";
            c.modelo = "vazio";
            c.placa = "vazio";

            carros.Add(c);

        }




        public void armazenaCarro(string marca, string modelo, string placa)
        {
            Carro c = new Carro(marca, modelo, placa);

            for(int i = 0; i < carros.Count; i++)
            {
                if (carros[i].marca == "vazio" && carros[i].modelo == "vazio" && carros[i].placa == "vazio")
                {
                    carros.Add(c);
                }
                else
                {
                    carros.Add(c);
                    Console.WriteLine("carro add fora do setor vazio");
                }

            }


            

        }

        

        public Carro buscaCarro(string placa)
        {
            Carro r = null;

            foreach (Carro c in carros)
            {
                if (c.placa.Equals(placa))
                {
                    r = c;
                }
                else
                {
                   
                }
            }
            return r;
        }
       

        public void mostraEstacionamento()
        {
            for (int i = 0; i < carros.Count; i++)
            {
                Console.WriteLine("posicao [" + i + "]: " + carros[i].modelo + " " + carros[i].marca + " " + carros[i].placa);
            }
        }

        public Carro trocaPorVazio(string placa)
        {
            var vaxio = "vaxio";

            for(int i = 0; i < carros.Count; i ++)
            {
                if (carros[i].placa == placa)
                {
                    carros[i].modelo = "vazio";
                    carros[i].marca = "vazio";
                    carros[i].placa = "vazio";

                    //carros.Add(carros[i]); caso esta for habilitada, alem de modificar as posicoes por "vazio" add um novo carro vazio na lista. (erro)

                }
                
            }

            return null;
        }
    }
}
