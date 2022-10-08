namespace ex01classeLivro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paginas, capitulos;

            string titulo, autor, editora;

            double preco;

            Console.WriteLine("livraria\n");


            Console.WriteLine("digite o capitulo: ");

            capitulos = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o pagina: ");

            paginas = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o titulo: ");

            titulo = Console.ReadLine();

            Console.WriteLine("digite o autor: ");

            autor = Console.ReadLine();

            Console.WriteLine("digite o editor: ");

            editora = Console.ReadLine();

            Console.WriteLine("digite o preço: ");

            preco = double.Parse(Console.ReadLine());


            Livro L1 = new Livro(paginas, capitulos, titulo, autor, editora, preco);


            L1.ler(capitulos,paginas);

            L1.livro(titulo,autor,editora);
 

        }
    }
}