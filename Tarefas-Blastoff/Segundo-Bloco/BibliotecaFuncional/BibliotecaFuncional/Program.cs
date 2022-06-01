using BibliotecaFuncional.Entities;
using System;
using System.Text.RegularExpressions;

namespace BibliotecaFuncional
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Biblioteca b1 = new Biblioteca();
           
            Menu(b1);
        }

        static void Menu(Biblioteca b1)
        {
            short option = 0;
            bool optionPossible;

            Console.Clear();
            Console.WriteLine("Sistema de ajuda metragem de pisos");
            System.Console.WriteLine("1 - Adicionar Livro");
            Console.WriteLine("2 - Exibir Dados dos livros");
            System.Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible)
            {
                Console.Clear();
                System.Console.WriteLine("Insira o valor no intervalo indicado");
                Thread.Sleep(2500);
                Menu(b1);
            }
            else
            {
                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();

                            string regraTitulo = @"[A-Za-zÀ-Ÿ][A-zÀ-ÿ' ]+";
                            string regraIsbn = @"[0-9]{3}-[0-9]-[0-9]{4}-[0-9]{4}-[0-9]";
                            Regex regexTitulo = new Regex(regraTitulo);
                            Regex regexIsbn = new Regex(regraIsbn);
                            string titulo;
                            string isbn;
                            int quantidadePaginas;
                            bool possivel;

                            do
                            {
                                Console.WriteLine("Digite o título do livro");
                                titulo = Console.ReadLine();

                            }while(!regexTitulo.IsMatch(titulo));

                            do
                            {
                                Console.WriteLine("Digite o ISBN do livro");
                                isbn = Console.ReadLine();
                            } while(!regexIsbn.IsMatch(isbn));

                            do
                            {
                                Console.WriteLine("Digite a quantidade de páginas do livro");
                                possivel = int.TryParse(Console.ReadLine(), out quantidadePaginas);
                            } while (!possivel || quantidadePaginas < 0);

                            Livro livro = new Livro(titulo, isbn, quantidadePaginas);

                            b1.AddList(livro);

                            Console.WriteLine("O livro foi adicionado com sucesso");
                            Thread.Sleep(1000);
                            Console.WriteLine("Dê enter para voltar ao Menu");
                            Console.ReadLine();
                            Menu(b1);
                            break;
                        }
                    case 2:
                        {
                           if(b1 == null)
                            {
                                Console.WriteLine("Não tem dados o suficiente na lista. Adicione Livros!");
                            }
                            else
                            {
                                List<Livro> l1 = b1.GetLivros();
                                foreach(Livro l in l1)
                                {
                                    l.ExibirDados();
                                }
                            }

                            Thread.Sleep(1000);
                            Console.WriteLine("Dê enter para voltar ao Menu");
                            Console.ReadLine();
                            Menu(b1);

                            break;
                        }
                    case 0:
                        {
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            System.Console.WriteLine("Insira o valor no intervalo indicado");
                            Thread.Sleep(1000);
                            Menu(b1);
                            break;
                        }
                }
            }
        }
    }
}
