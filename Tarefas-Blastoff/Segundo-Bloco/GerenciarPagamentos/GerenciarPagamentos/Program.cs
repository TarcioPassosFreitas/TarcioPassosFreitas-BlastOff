using GerenciarPagamentos.Entities;
using System;

namespace GerenciarPagamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Menu(funcionarios);
        }

        static void Menu(List<Funcionario> funcionarios)
        {
            Console.Clear();
            short option = 0;
            bool optionPossible;

            Console.Clear();
            System.Console.WriteLine("Gerenciamento de Pagamentos");
            System.Console.WriteLine("1 - Adicionar Funcionarios");
            Console.WriteLine("2 - Lista de Funcionários e seus salários");
            Console.WriteLine("3 - Escolha um funcionário e dê uma bonificação");
            System.Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible || option < 0 || option > 3)
            {
                Console.Clear();
                System.Console.WriteLine("Insira o valor no intervalo indicado");
                Thread.Sleep(2500);
                Menu(funcionarios);
            }
            else
            {
                switch (option)
                {
                    case 1:
                        {

                            break;
                        }
                    case 2:
                        {

                            break;
                        }
                    case 3:
                        {

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
                            Thread.Sleep(2500);
                            Menu();
                            break;
                        }
                }
            }
        }
    }
}
