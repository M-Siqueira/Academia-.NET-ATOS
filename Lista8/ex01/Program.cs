namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1) Implemente um programa em C# no qual o usuário deverá informar o nome e o poder
            //            (0 a 10) de três personagens. 
            //              O programa deverá informar o nome do personagem que possuir o maior poder.
            //            Regras que deverão ser seguidas para a implementação do algoritmo:

            //            É obrigatório o uso de classe para representar um Personagem
            //            e a mesma deverá possuir como propriedades(características) um nome e um poder.

            //             A classe também deverá possuir um método chamado ExibirDados.
            //             Esse método deverá exibir o nome e o poder do personagem em questão.
            //Ao implementar a classe é obrigatório implementar dois construtores(Sobrecarga), um que não recebe parâmetro algum e outro que
            //irá receber o nome e o poder de um personagem


            List<string> list = new List<string>();
            List<int> list2 = new List<int>();


            string nome;
            int poder;




            for (int i = 0; i < 3; i++)//3 personagens espeficicamente
            {
                Console.WriteLine("cadastro de 3 personagens: \n");


                Console.WriteLine("nome do personagem");

                nome = Console.ReadLine();

                Console.WriteLine("poder do personagem do personagem.(0 a 10)");

                poder = int.Parse(Console.ReadLine());

                list.Add(nome);

                list2.Add(poder);
                
            }

            Personagem personagem = new Personagem();

            personagem.ExibeDados(list, list2);

            

        }
    }
}