using System.Runtime.Intrinsics.Arm;

namespace ex06
{
    internal class Program
    {          // 6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura.Exemplo:
                //a.lê: 		|7|40|3|9|21|0|63|31|7|22|
                //b.escreve: 	|22|7|31|63|0|21|9|3|40|7|

        static void Main(string[] args)
        {
            int[] mat = new int[10];


            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("digite o numero");
                mat[i] = int.Parse(Console.ReadLine());

            }

            for(int i = 9; i >= 0; i--)
            {
                Console.Write("|"+mat[i]);
            }
        }
    }
}