namespace ex01
{
    internal class Program
    {   //1.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

        static void Main(string[] args)
        {
            int[] elementos = new int[10];
            int i,par = 0, impar = 0;

            for (i = 0; i < elementos.Length; i++)
            {
                Console.WriteLine("digite o valor: \n");
                elementos[i] = int.Parse(Console.ReadLine());

                if (elementos[i] %2 == 0 )
                {
                    par++;
                }
                if (elementos[i] % 2 != 0)
                {
                    impar++;
                }
            }

            Console.WriteLine("quantidade de numeros pares: "+ par);
            Console.WriteLine("quantidade de numeros impares: " + impar);

        }
    }
}