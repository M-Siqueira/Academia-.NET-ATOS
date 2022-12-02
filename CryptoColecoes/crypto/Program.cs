
//        List<string> palavras = new List<string>();

//        for (int i = 0; i< 5; i++){

//                Console.WriteLine("palavra");
//                palavras.Add(Console.ReadLine());

//            }


//Console.WriteLine("palavra para pesquisar");
//string pesquisa = Console.ReadLine();

//    if (palavras.Contains(pesquisa))
//    {
//        palavras.Add ("nome2");
//    }

//palavras.Sort();

//       foreach(var item in palavras){

//                 Console.WriteLine(item);
//            }



using crypto;
using System.Linq;

List<Pessoa> pessoas = new List<Pessoa>();

string nome;

string cpf;

DateOnly dataNascimento;

Pessoa p;


for (int i = 0; i < 3; i++)
{

    Console.WriteLine("nome");
    nome = Console.ReadLine();


    Console.WriteLine("cpf");
    cpf = Console.ReadLine();

    Console.WriteLine("data nascimento");
    dataNascimento = DateOnly.Parse(Console.ReadLine());

    p = new Pessoa(nome, cpf, dataNascimento);

    if (!pessoas.Contains(p))
    {
        pessoas.Add(p);
    }
    else
    {
        Console.WriteLine(p + "contem na lista, naopode ser adicionado!");
        break;
    }


}


        


foreach (var item in pessoas)
{

    Console.WriteLine(item);
}

