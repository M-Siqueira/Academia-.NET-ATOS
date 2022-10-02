namespace ex17
{
    internal class Program
    {   //17. Apresentar os quadrados dos números inteiros de 15 a 200.
        // a principio todos sao inteiros 

        static void Main(string[] args)
        {
            double resp;

            for (int i = 15; i < 201; i++)
            {
                resp = Math.Pow(i, 2);
            
                Console.WriteLine("o quadrado do numero "+ i +" é: "+resp);
            }
        }
    }
}