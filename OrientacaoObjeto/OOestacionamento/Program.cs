using System.Numerics;
using System.Reflection;

namespace OOestacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Estacionamento e = new Estacionamento("Estacionamento do Centro");
            string fabricante;
            string modelo;
            string placa;
            Carro consulta = null;

            e.inicializaEstacionamento("vazio","vazio","vazio");

            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar carro\nDigite 2 para buscar as informações \nDigite 3 para apagar carro\nDigite 4 para sair");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Digite o fabricante do carro: ");
                    fabricante = Console.ReadLine();
                    Console.WriteLine("Digite o modelo do carro: ");
                    modelo = Console.ReadLine();
                    Console.WriteLine("Digite a placa do carro: ");
                    placa = Console.ReadLine();
                    e.armazenaCarro(fabricante, modelo, placa);
                    
                    Console.Clear();
                    e.mostraEstacionamento();
                }
                if (op == 2)
                {
                    Console.WriteLine("Digite a placa do automovel que sairá: ");
                    placa = Console.ReadLine();
                    consulta = e.buscaCarro(placa);
                    if (consulta != null)
                    {
                        Console.WriteLine("Carro ENCONTRADO! Modelo: " + consulta.modelo + " Placa " + consulta.placa);

                    }
                    else
                    {
                        Console.WriteLine("Carro não encontrado!");
                    }
                }
                if (op == 3)
                {
                    Console.WriteLine("Digite a placa do automovel que sairá: ");
                    placa = Console.ReadLine();
                    //e.removeCarro(placa);
                    e.trocaPorVazio(placa); //esta opcao troca todas AS INFORMACOES DA VAGA DO CARRO POR "VAZIO".
                    e.mostraEstacionamento();// mostrando estacionamento afim didadito;
                }
                if (op == 4)
                {
                    break;
                }
            }
        }
    }
}