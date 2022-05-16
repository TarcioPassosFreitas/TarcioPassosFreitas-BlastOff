using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFuncional.Entities
{
    internal class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();

        public Biblioteca()
        {

        }

        public void AddList(Livro l1)
        {
            this.livros.Add(l1);
        }

        public List<Livro> GetLivros()
        {
            return livros;
        }

        public void MaiorQuantidadePaginas()
        {
            List<Livro> sorted = livros.OrderBy(x => x.GetQuantidadePaginas()).ToList();
            sorted.Reverse();
            Console.WriteLine("Maior quantidade de páginas em ordem decrescente");
            foreach (Livro livro in sorted)
            {
                Console.WriteLine(livro.GetTitulo() + ", " + livro.GetISBN() + ", " +  
                    livro.GetQuantidadePaginas()) ;
            }

        }

        public void MenorQuantidadePaginas()
        {
            List<Livro> sorted = livros.OrderBy(x => x.GetQuantidadePaginas()).ToList();
            Console.WriteLine("Menor quantidade de páginas em ordem decrescente");
            foreach (Livro livro in sorted)
            {
                Console.WriteLine(livro.GetTitulo() + ", " + livro.GetISBN() + ", " +
                    livro.GetQuantidadePaginas());
            }
        }
    }
}
