namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            16.Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva.Crie, a seguir, um vetor para cada uma das operações:
            //•	A união de X com Y
            //•	A diferença entre X e Y
            //•	A interseção entre X e Y
            //Escreva o vetor resultado de cada uma das operações.
            int t = 5;

            int[] x = new int[t];
            int[] y = new int[t];
            int[] uniao = new int[t];
            int[] diferenca = new int[t];
            int[] interseccao = new int[t];

            int iguais = 0, diferente = 0;

            for(int i = 0; i < t; i++)
            {
                Console.WriteLine("digite um numero");
                x[i] = int.Parse(Console.ReadLine());
            }
            for(int j = 0; j < t; j++)
            {
                Console.WriteLine("digite um numero");
                y[j] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < t; i++)
            {
                Console.Write("|" + x[i]+"|");
                
            }
            Console.WriteLine("\n");

            for (int j = 0; j < t; j++)
            {
                Console.Write("|" + y[j] + "|");
                
            }
            Console.WriteLine("\n");


            for (int i = 0;i < t; i++)
            {
                for(int j = 0; j < t; j++)
                {
                    if (x[i] == y[j])
                    {
                        iguais++;
                        interseccao[j] = y[j];

                    }
                    if (x[i] != y[j])
                    {
                        diferente++;
                        diferenca[j] = y[j];

                    }
                }
            }

            Console.WriteLine("sao iguais: "+ iguais);
            Console.WriteLine("sao diferentes: "+ diferente);
            Console.WriteLine("\n");

            for (int i = 0; i < t; i++)
            {
                if (interseccao[i] != 0)
                {
                    Console.WriteLine("interseccao:" + interseccao[i]);
                }
            }

            //incompleto

        }
    }
}