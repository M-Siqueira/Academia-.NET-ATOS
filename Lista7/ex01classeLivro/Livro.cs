using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01classeLivro
{
    internal class Livro
    {
       private int paginas;
         private int capitulos;
         private string titulo;
         private string autor;
        private string editora;
        private double preco;

        public Livro(int paginas, int capitulos, string titulo, string autor, string editora, double preco)
        {
            this.paginas = paginas;
            this.capitulos = capitulos;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.preco = preco;
        }

        public void ler(int capitulo, int pagina)
        {
            
            Console.WriteLine("lendo capitulo "+capitulo+ " e pagina "+pagina);

        }

        public void livro(string titulo, string autor, string editora)
        {

            Console.WriteLine("lendo livro " + titulo + " da editora " + editora+ " autor: "+ autor);

        }






    }
}
