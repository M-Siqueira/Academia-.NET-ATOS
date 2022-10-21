// Manipulando arquivos texto/
using exFIgurinhaCopa;
using System;
using System.Collections.Generic;


// string frase = "";
// List<string> listaDeFrases = new List<string>();

// //conecto o sistema com a base de dados
// Util.popularArquivoNaListaString(listaDeFrases,"frases.txt");

// //lista conteúdo da base de dados
// Console.WriteLine("Frase já cadastradas!");
// Util.mostrarLista(listaDeFrases);

// while (true) {
//     Console.Write("Digite uma frase qualquer ou sair: ");
//     frase = Console.ReadLine();
//     if (frase.ToUpper() == "SAIR") {
//         break;
//     }
//     //adicionar na lista a frase, desque que não esteja cadastrada
//     if (listaDeFrases.Contains(frase.ToUpper())) {
//         Console.WriteLine("Frase já cadastrada na estrutura!");
//     } else {
//         listaDeFrases.Add(frase);        
//         //gravar ou persistir o dado no arquivo
//         Util.gravarFraseArquivo(frase, "frases.txt");
//     }
// }



List<Figurinha> listaDePessoas = new List<Figurinha>();

//conecta com a base de dados
Console.WriteLine("Pessoas já cadastradas!");
Util.popularArquivoNaListaPessoa(listaDePessoas, "pessoas.csv");

//mostrar o conteúdo da lista
Util.mostrarListaPessoa(listaDePessoas);
string opcao;
string nome;
string email;
Figurinha figurinha;
do
{
    Console.Write("Nome: ");
    nome = Console.ReadLine();

    Console.Write("Email: ");
    email = Console.ReadLine();

    figurinha = new Figurinha();

    if (Util.jaNaListaPessoa(figurinha, listaDePessoas))
    {
        Console.WriteLine("Pessoa já cadastrada com este email!");
    }
    else
    {
        listaDePessoas.Add(figurinha);

        //persistir o dado no arquivo
        Util.gravarFiguraArquivo(figurinha, "pessoas.csv");
    }

    Console.Write("1 - Continua; Outra tecla finaliza!");
    opcao = Console.ReadLine();
} while (opcao == "1");