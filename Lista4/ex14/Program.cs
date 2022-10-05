using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;

namespace ex14
{
    internal class Program
    {
        // 14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números.
        // Se o código for zero, termine o algoritmo.
        // Se o código for 1, mostre o vetor na ordem em que foi lido.
        // Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

        static void Main(string[] args)
        { 
            int resposta,t = 5;

            int[] vet = new int[t];

            for(int i = 0; i < t; i++)
            {
                Console.WriteLine("digite um numero:\n");
                vet[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("numero 0 para finalizar:\n");
            Console.WriteLine("numero 1 para ordem digitada:\n");
            Console.WriteLine("numero 2 para ordem inversa:\n");
            resposta = int.Parse(Console.ReadLine());



            switch (resposta)
            {
                case 0:
                    Console.WriteLine("finalizado");
                    break;
                case 1:

                    for(int i = 0; i < t; i++)
                    {
                        Console.WriteLine("valor da posicao: " + i + ":" + vet[i]);
                    }
                    
                    break;

                case 2:
                    for (int i = 4; i >= 0; i--)
                    {
                        Console.WriteLine("valor da posicao: " + i + ":" + vet[i]);
                    }

                    break;
            }
        }
    }
}