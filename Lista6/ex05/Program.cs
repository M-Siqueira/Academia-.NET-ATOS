using System.Collections.Generic;
using System.Reflection;

namespace ex05
{
    internal class Program
    {
        //        5. Crie um programa em VS que popule duas listas(lista1 e lista2) com números aleatórios(100 a 200).
        //A quantidade de números deve ser informada pelo usuário.Em seguida, o programa deve listar os
        //conteúdos das duas listas e exibir os números que aparecem em ambas as listas.


        static void Main(string[] args)
        {
            int a, b, i, j, tamanho;

            List<int> list = new List<int>();

            List<int> list2 = new List<int>();

            List<int> iguais = new List<int>();

            Random gerador = new Random();


            Console.WriteLine("qual tamanho das listas? \n");
            tamanho = int.Parse(Console.ReadLine());

            for (i = 0; i < tamanho; i++)
            {

                a = gerador.Next(10, 20);

                list.Add(a);

                b = gerador.Next(10, 20);

                list2.Add(b);
            }
            Console.WriteLine("lista 1: \n");
            foreach (var s in list)
            {

                Console.Write("[" + s + "]");
            }
            Console.WriteLine("\n");
            Console.WriteLine("lista 2: \n");
            foreach (var y in list2)
            {

                Console.Write("[" + y + "]");
            }
            Console.WriteLine("\n");

            for (i = 0; i < list.Count; i++)
            {
                for (j = 0; j < list2.Count; j++)
                {
                    if (list[i] == list2[j])
                    {
                        if (iguais.Contains(list[i]))
                        {
                            break;
                        }
                        else
                        {
                            iguais.Add(list[i]);
                        }
                    }
                }
            }
            Console.WriteLine("repetidos em ambas listas: \n");
            foreach (var z in iguais)
            {

                Console.Write("[" + z + "]");
            }
            Console.WriteLine("\n");


        }
    }
}