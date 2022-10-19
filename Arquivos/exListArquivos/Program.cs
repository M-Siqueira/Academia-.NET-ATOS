namespace exListArquivos

{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //manipulando textos



            List<string> listaFrases = new List<string>();

            while (true)
            {
                string frase;
                Console.WriteLine("digite uma frase qualquer ou sair..");

                frase = Console.ReadLine();

               

                if (frase.ToUpper() == "SAIR")
                {
                   break;   
                }
                else
                {
                    if (listaFrases.Contains(frase.ToUpper())){

                        Console.WriteLine("contem frase......");
                    }
                    else {
                        string fraseF = frase.ToUpper();

                        listaFrases.Add(fraseF);

                        Util.gravarArquivo(frase.ToUpper()+";", "frases.txt");
                    }
                }

            }
        }
    }
}