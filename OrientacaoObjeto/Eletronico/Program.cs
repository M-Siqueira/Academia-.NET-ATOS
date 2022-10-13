namespace Eletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televisao T = new Televisao();
            Play P = new Play();
            Celular celular = new Celular();

            int option;

            while (true)
            {
                Console.WriteLine("ligar equipamento? ");
                Console.WriteLine("1- ligar");
                Console.WriteLine("2- desligar");
                Console.WriteLine("3- informa se ligado ou desligado");
                Console.WriteLine("4- sair");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Clear();
                    if (T.Ligado)
                    {
                        Console.WriteLine("ja ligado");
                    }
                    else
                    {
                        T.Ligar();
                    }
                    
                }
                if (option == 2)
                {
                    Console.Clear();
                    if (!T.Ligado)
                    {
                        Console.WriteLine("ja desligado");
                    }
                    else
                    {
                        T.Desligar();
                    }

                   
                }
                if (option == 3)
                {
                    Console.Clear();
                    if (T.Ligado)
                    {
                        Console.WriteLine("ja ligado");
                    }
                    else
                    {
                        Console.WriteLine("ja desligado");
                    }
                    
                }
                if (option == 4)
                {
                    break;
                }





            }







        }
    }
}