using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1Aviao
{
    internal class aviao
    {
        private string modelo;
        public double velocidade;
        public double altitude;
        private string marca;
        
        public void reduzir()
        {
            velocidade = velocidade - 10;
            Console.WriteLine("reduzindo velocidade"+ velocidade);
        }
        public void acelerar()
        {
            velocidade = velocidade + 10;
            Console.WriteLine("aumentando velocidade"+ velocidade);
        }
        public void descer()
        {
            altitude = altitude - 100;

            Console.WriteLine("subindo" + altitude);
        }
        public void subir()
        {
            altitude = altitude + 100;
            Console.WriteLine("descendo"+ altitude);
        }



    }
}
