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

        public List<Livro> GetLivros()
        {
            return livros;
        }

        public void MaiorQuantidadePaginas()
        {

        }

        public void MenorQuantidadePaginas()
        {

        }
    }
}
