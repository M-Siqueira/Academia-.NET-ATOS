namespace ExemploOo01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //console classe nativa
            //writeLine() metodo declasse da classe console
            //classe.metodoDeClasse()

            //cubo é um metodo

            // chave é um atributo
            // Console.WriteLine("digite uma frase: \n");
            // string frase = Console.ReadLine();
            //Console.Beep();

            //frase é um obj da classe string q encapsula atrib e met da classe string.

            // int tamanhoDaFrase = frase.Length;
            // frase = frase.ToUpper();

            // Random gerador = new Random(); //metodo construtor da classe é chamado.
            // aloca memoria para o objeto.
            //int numero = gerador.Next(10,50); //gera de 0 ate 50 um numero aleatorio.
            //next é um metodo com retorno
            //possui 3 opcoes de comportamento.  polimorfismo de sobrecarga


            // Console.WriteLine(numero);

            // Console.WriteLine(gerador.NextDouble());



            //nomePessoas.Add("rafael");
            //nomePessoas.Add("isabela");
            //nomePessoas.Add("marcelo");
            //nomePessoas.Add("kaue");

            //metodo de adicionar na lista
            //este add no fim. 



            List<string> nomePessoas = new List<string>(); //construtor que instancia obj nomes pessoas em memoria

            do
            {
                Console.WriteLine("digite um nopme");
                string nome = Console.ReadLine().ToUpper();

                if (nome == "SAIR")
                {
                    Console.WriteLine("saindo");
                    break;
                }
                if (nomePessoas.Contains(nome))
                {
                    Console.WriteLine("tem na lista");
                    
                }
                if(!nomePessoas.Contains(nome))
                {
                    nomePessoas.Add(nome);
                }


            } while (true);


            for (int i = 0; i < nomePessoas.Count; i++) //atributo de obj.  
            {
                Console.WriteLine(nomePessoas[i].ToUpper());
            }

            do
            {
                Console.WriteLine("digite um nopme para remover:");
                string nome = Console.ReadLine().ToUpper();

                if (nome == "SAIR")
                {
                    Console.WriteLine("saindo");
                    break;
                }
                if (nomePessoas.Contains(nome))
                {
                    nomePessoas.Remove(nome);

                }
               

            } while (true);

            //for (int i = 0; i < nomePessoas.Count; i++) //atributo de obj.  
            //{
            //    Console.WriteLine(nomePessoas[i].ToUpper());
            //}

            foreach(var pessoa in nomePessoas)
            {
                Console.WriteLine(pessoa);
            }





        }
    }
}