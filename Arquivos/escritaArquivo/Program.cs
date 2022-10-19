namespace escritaArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\marce\\Desktop\\atosUfn.txt");
            //StreamWriter writer = new StreamWriter(@"C:\Users\marce\Desktop\atosUfn.txt");

            writer.WriteLine("segunda feira");
            writer.WriteLine("\n");
            writer.WriteLine("aula atos ufn");
            writer.WriteLine("\n");
            writer.WriteLine("17/10/22");
            writer.WriteLine("\n");

            writer.Close(); 


           
        }
    }
}