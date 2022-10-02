namespace exemplo_4v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double media = 0;
            double[] nota = new double[5];

            Console.WriteLine("leitura de notas de aluno\n");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("digite a nota " + i + " : ");
                nota[i] = int.Parse(Console.ReadLine());
            }


            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("valor indice " + i + " igual a: " + nota[i]);
                media += nota[i];

            }
            media = media / 5;

            Console.WriteLine("mostra media\n");
            Console.WriteLine("media igual: "+ media);
        }
    }
}