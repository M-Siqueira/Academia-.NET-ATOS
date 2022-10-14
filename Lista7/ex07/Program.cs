using System.Runtime.Intrinsics.X86;
using System;

namespace ex07
{
    internal class Program
    {
        //        7 - Crie uma classe denominada Elevador para armazenar as informações de um elevador dentro de um prédio.
        //        A classe deve armazenar o andar atual (térreo = 0),
        //        total de andares no prédio(desconsiderando o térreo),
        //        capacidade do elevador e quantas pessoas estão presentes nele.
        //        A classe deve também disponibilizar os seguintes métodos:
        //        Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de andares no prédio(os elevadores sempre começam no térreo e vazio);
        //        Entra : para acrescentar uma pessoa no elevador(só deve acrescentar se ainda houver espaço);
        //        Sai : para remover uma pessoa do elevador(só deve remover se houver alguém dentro dele);
        //        Sobe : para subir um andar(não deve subir se já estiver no último andar);
        //        Desce : para descer um andar(não deve descer se já estiver no térreo);
        //        Encapsular todos os atributos da classe(criar os métodos set e get).
        static void Main(string[] args)
        {
            int option,passageiros;
            
            Elevador E = new Elevador();

            E.inicializa();


            while (true)
            {
                Console.WriteLine("elevador:\n");
                Console.WriteLine("1- sobe.");
                Console.WriteLine("2- desce.");
                option = int.Parse(Console.ReadLine());
                Console.Beep();
                Console.WriteLine("\n");

                if (option == 1)//sobir
                {

                    Console.WriteLine("quantos passageiros?");
                    passageiros = int.Parse(Console.ReadLine());

                    E.sobe(passageiros);
                    

                }else if(option == 2)//descer
                {
                    Console.WriteLine("quantos passageiros?");
                    passageiros = int.Parse(Console.ReadLine());
                    E.desce(passageiros);
                    

                }




            }
        }
    }
}