using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
    internal class Elevador
    {
        private int _andarAtual = 0 ;//terreo
        private int _totalAndares = 10;
        private int _totalPessoas;
        private int _totalMaximo = 10;

        public int AndarAtual { get => _andarAtual; set => _andarAtual = value; }
        public int TotalAndares { get => _totalAndares; set => _totalAndares = value; }
        public int TotalPessoas { get => _totalPessoas; set => _totalPessoas = value; }
        public int TotalMaximo { get => _totalMaximo; set => _totalMaximo = value; }

        public void inicializa()
        {
            this._andarAtual = _andarAtual;
        }

        public void entra(int entrada)
        {
            if((_totalPessoas + entrada) > _totalMaximo)
            {
                Console.WriteLine("elevador cheio.");
            }
            else
            {
                Console.WriteLine("pessoas adicionadas com exito");
                _totalPessoas = _totalPessoas + entrada;
            }
        }
        public void sai(int saida)
        {
            if (_totalPessoas >= 1) {

                _totalPessoas = _totalPessoas - saida;
                Console.WriteLine("elevador esvaziado com exito");
            }
            else
            {
                //nao para para sair ninguem.
                Console.WriteLine("elevador ja esta vazio, ninguem para sair.");
            }
            
        }
        public void sobe(int andarMais)
        {
            if (_andarAtual == 0 )
            {
                _andarAtual = _andarAtual + andarMais;
                Console.WriteLine("andar atual: " + _andarAtual);
            }
            
        }

        public void desce(int andarMenos)
        {
            if (_andarAtual == _totalAndares)
            {
                //desce
                _andarAtual = _andarAtual - andarMenos;
                Console.WriteLine("andar atual: "+_andarAtual);
            }
        }
    }
}
