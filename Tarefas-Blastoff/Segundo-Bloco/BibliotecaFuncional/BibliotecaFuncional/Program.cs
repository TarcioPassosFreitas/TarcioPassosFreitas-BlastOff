using BibliotecaFuncional.Entities;
using System;

namespace BibliotecaFuncional // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("lala", "huhu", 60);
            Livro livro2 = new Livro("lala2", "huhu2", 40);
            Livro livro3 = new Livro("lala3", "huhu3", 20);
            Livro livro4 = new Livro("lala4", "huhu4", 50);

            Biblioteca b1 = new Biblioteca();
            b1.AddList(livro);
            b1.AddList(livro2);
            b1.AddList(livro3);
            b1.AddList(livro4);

            b1.MenorQuantidadePaginas();

        }
    }
}
