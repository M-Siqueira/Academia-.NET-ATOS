namespace criaClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool retorno;

            Console.WriteLine("presents class met e obj OO ");

            lampada l1 = new lampada();
            l1.ligar();

            l1.desligar();

            retorno = l1.estaLigada();

            l1.teste = 10;

            Console.WriteLine(l1.estaLigada());

            
        }
    }
}