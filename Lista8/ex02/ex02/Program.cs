namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> bixo = new Dictionary<string, string>();

            string tipo, nome;
            int contaAnimal = 0;

            do
            {
                Console.WriteLine("cadastro de animais: \n");
                Console.WriteLine("tipo do seu animal? (peixe, cachorro ou gato) \n");
                
                tipo = Console.ReadLine();

                string tipoM = tipo.ToUpper();

                Console.WriteLine("nome do seu animal \n");
                nome = Console.ReadLine();
                string nomeM = nome.ToUpper();

                if (tipoM == "PEIXE" || tipoM == "CACHORRO" || tipoM == "GATO")
                {
                    Animal animal = new Animal(tipoM,nomeM);

                    animal.adicinaAnimal(animal.Nome, animal.Raça);

                    contaAnimal++;  

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("tipo de anival nao valido, tente novamente...");
                    
                    continue;
                }


            } while (contaAnimal < 5);

            

            

            

        }
    }
}