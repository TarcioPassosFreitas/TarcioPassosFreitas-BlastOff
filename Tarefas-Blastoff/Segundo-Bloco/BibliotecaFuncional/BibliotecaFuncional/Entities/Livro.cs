using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFuncional.Entities
{
    internal class Livro
    {
        private string Titulo;
        private string ISBN;
        private int QuantidadePaginas;

        public Livro()
        {

        }

        public Livro(string titulo, string isbn, int QuantidadePaginas)
        {
            this.Titulo = titulo;
            this.ISBN = isbn;
            this.QuantidadePaginas = QuantidadePaginas;
        }

        public string GetTitulo()
        {
            return Titulo;
        }

        public void SetTitulo(string titulo)
        {
            this.Titulo = titulo;
        }

        public string GetISBN()
        {
            return ISBN;
        }

        public void SetISBN(string isbn)
        {
            this.ISBN = isbn;
        }

        public int GetQuantidadePaginas()
        {
            return QuantidadePaginas;
        }

        public void SetQuantidadePaginas(int quantidadePaginas)
        {
            this.QuantidadePaginas = quantidadePaginas;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"O livro '{this.GetTitulo()}' tem como ISBN: {this.ISBN} e possui {this.QuantidadePaginas} páginas.");
        }
    }
}
