namespace exExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\marce\\Desktop\\teste.txt");//leitura

            StreamWriter sw = new StreamWriter(path: "C:\\Users\\marce\\Desktop\\teste.txt", append: true);//escrita

            string nome, sexo, email, telefone, estadoCivil;
            bool casaPropria;
            double valorAluguel;

            Console.WriteLine("qual seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("qual seu sexo?");
            sexo = Console.ReadLine();

            Console.WriteLine("qual seu email?");
            email = Console.ReadLine();

            Console.WriteLine("qual seu telefone?");
            telefone = Console.ReadLine();

            Console.WriteLine("qual seu estado civil?");
            estadoCivil = Console.ReadLine();

            Console.WriteLine("casa propria?");
            casaPropria = bool.Parse(Console.ReadLine());

            Console.WriteLine("valor do aluguel?");
            valorAluguel = double.Parse(Console.ReadLine());


            List<string> linhas = new List<string>();

            linhas.Add(sr.ReadLine());

            string linha = "";

            while (linha != null)
            {
                linha = sr.ReadLine();
                linhas.Add(linha);
            }
            sw.Close();

            linhas.Add(nome + ";" + sexo + ";" + email + ";" + telefone + ";" + estadoCivil + ";" + casaPropria + ";" + valorAluguel);

           















            Console.WriteLine("----------------------------------------------");

            linha = sr.ReadToEnd();

            while (linha != null)
            {
                

                Console.WriteLine(linha);
                linha = sr.ReadLine();


            }

            Console.WriteLine("----------------------------------------------");

            sr.Close();//fecha leitura


        }
    }
}



//if (File.Exists())
//{
//    //ler arquivo. 
//}
//else
//{
//    //criar novo arquivo
//}