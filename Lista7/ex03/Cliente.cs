﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Cliente
    {
        private string nome;
        private int idade;
        private int datacnh;
        private string cartao;
       

        public Cliente(string nome, int  idade, int datacnh)
        {
            this.nome = nome;
            this.idade = idade;
            this.datacnh = datacnh;
            

        }

       

        public void ClienteApto(int idade, int datacnh)
        {
            

            if (idade >= 21 && datacnh <= 2020)
            {
                Console.WriteLine("apto a locação");

            }
            else
            {
                Console.WriteLine("dados minimos nao batem para locação");
            }
            
        }




    }
}
