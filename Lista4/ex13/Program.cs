using System.Runtime.ConstrainedExecution;

namespace ex13
{
    internal class Program
    {
        //13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8.
        //O vetor terá no máximo 100 posições.Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.
        static void Main(string[] args)
        {
            double[] vet = new double[10];
            double aux,a=0,b=0,c=0;

            for(int i = 0; i < 10; i++)
            {
                do {

                    Console.WriteLine("digite um valor: \n");
                    vet[i] = double.Parse(Console.ReadLine());
                    aux = Convert.ToInt32(vet[i]);
                    if ((vet[i] == -1)||( i > 9 ))
                    {
                        Console.WriteLine("saindo do programa.");
                        return;
                    }
                }while ((aux != vet[i]) || (vet[i]<0));

                if (aux == 2)
                {
                    a++;
                }
                if (aux == 4)
                {
                    b++;
                }
                if (aux == 8)
                {
                    c++;
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine(":" + a +" numeros 2 digitados. \n");
            Console.WriteLine(":" + b + " numeros 4 digitados. \n");
            Console.WriteLine(":" + c + " numeros 8 digitados. \n");
        }
    }
}