namespace exemplo_03
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int i;
            int[] b = new int[5];

            Console.WriteLine("leitura de valor\n");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("digite o numero "+ i + " : ");
                b[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("valor indice " + i + " igual a: "+ b[i]);
                
            }
        }
    }
}