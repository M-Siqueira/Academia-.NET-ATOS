using System.Runtime.CompilerServices;

namespace ex04
{
    internal class Program
    {

        // 4 - Faça um programa que represente a arvore genealógica da tua familia.
        // Para isso, uma classe Pessoa precisa ser indicar quem são seus pais, alem deinformações básicas sobre a pessoa.

        static void Main(string[] args)
        {
            
            Pessoa pAvo = new Pessoa();

            pAvo.nome = "atolero";
            pAvo.idade = 20;
            pAvo.pai = "barro";
            pAvo.mae = "terra";



            //===========================================================


            Pessoa pPai = new Pessoa();

            pPai.nome = "araldite";
            pPai.idade = 20;
            pPai.pai = "aroldo";
            pPai.mae = "aralda";


            //===========================================================


            Pessoa filho = new Pessoa();

            filho.nome = "aldinho";
            filho.idade = 20;
            filho.pai = "aldo";
            filho.mae = "alda";

            //=======================================================        

           pai = filho.mostraPai();




        }
    }
}