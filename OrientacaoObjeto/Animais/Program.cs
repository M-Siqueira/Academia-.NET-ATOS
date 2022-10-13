namespace Animais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peso = 120;
            Animal A = new Animal("rei leao", "masculino", "felino");

            Leao L = new Leao("rei leao", "masculino", "felino",120);

            A.Caminhar();
            A.EmitirSom();
            A.Dormir();

            L.Caminhar();
            L.EmitirSom();
            L.Dormir();
            L.Peso(peso);

            A.MostraDados("rei leao", "masculino", "felino", peso);


            Cusco c = new Cusco( );
        }
    }
}