using GerenciarPagamentos.Entities;
using System;
using System.Text.RegularExpressions;

namespace GerenciarPagamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            List<Gerente> gerentes = new List<Gerente>();
            List<Engenheiro> engenheiros = new List<Engenheiro>();
            Menu(funcionarios, gerentes, engenheiros);
        }

        static void Menu(List<Funcionario> funcionarios, List<Gerente> gerentes, List<Engenheiro> engenheiros)
        {
            Console.Clear();
            short option = 0;
            bool optionPossible;

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
                Menu(funcionarios, gerentes, engenheiros);
            }
            else
            {
                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();

                            string regraNome = @"[A-ZÀ-Ÿ][A-zÀ-ÿ' ]+";
                            string regraCpf = @"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}";
                            Regex regexNome = new Regex(regraNome);
                            Regex regexCpf = new Regex(regraCpf);

                            string nomeFuncionario;
                            string cpf;
                            double salario;
                            bool possivel;

                            do
                            {
                                Console.WriteLine("Digite o Nome do Funcionário (Primeira letra Maiúscula)");
                                nomeFuncionario = Console.ReadLine();
                            } while (!regexNome.IsMatch(nomeFuncionario));

                            do
                            {
                                Console.WriteLine("Digite o seu CPF no formato: xxx.xxx.xxx-xx");
                                cpf = Console.ReadLine();
                            } while (!regexCpf.IsMatch(cpf));

                            do
                            {
                                Console.WriteLine("Digite o salário desse funcionário");
                                possivel = double.TryParse(Console.ReadLine(), out salario);
                            } while (!possivel || salario < 1000);

                            MenuSecundario(nomeFuncionario, cpf, salario, funcionarios, gerentes, engenheiros);

                            break;
                        }
                    case 2:
                        {
                            Console.Clear();

                            if (funcionarios.Count() != 0 || gerentes.Count() != 0 || engenheiros.Count() != 0)
                            {
                                foreach (Funcionario f in funcionarios)
                                {
                                    Console.WriteLine($"Nome: {f.GetNome()}       Salário: {f.GetSalario()}");
                                }

                                foreach (Gerente g in gerentes)
                                {
                                    Console.WriteLine($"Nome: {g.GetNome()}       Salário: {g.GetSalario()}");
                                }

                                foreach (Engenheiro e in engenheiros)
                                {
                                    Console.WriteLine($"Nome: {e.GetNome()}       Salário: {e.GetSalario()}");
                                }

                                Thread.Sleep(1000);
                                Console.WriteLine("Dê Enter para voltar ao Menu principal");
                                Console.ReadLine();
                                Menu(funcionarios, gerentes, engenheiros);
                            }
                            else
                            {
                                Console.WriteLine("Não possui nenhum funcionário cadastrado ainda.");
                                Thread.Sleep(1000);
                                Console.WriteLine("Dê Enter para voltar ao Menu principal");
                                Console.ReadLine();
                                Menu(funcionarios, gerentes, engenheiros);
                            }
                            

                            break;
                        }
                    case 3:
                        {
                            Console.Clear();

                            if(funcionarios.Count() != 0 || gerentes.Count() != 0 || engenheiros.Count() != 0)
                            {
                                BuscarFuncionario(funcionarios, gerentes, engenheiros);

                                Thread.Sleep(1000);
                                Console.WriteLine("Dê Enter para voltar ao Menu principal");
                                Console.ReadLine();
                                Menu(funcionarios, gerentes, engenheiros);
                            }
                            else
                            {
                                Console.WriteLine("Não possui nenhum Funcionário ainda :(");
                                Console.WriteLine("Dê Enter para voltar ao Menu principal");
                                Console.ReadLine();
                                Menu(funcionarios, gerentes, engenheiros);
                            }

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
                            Menu(funcionarios, gerentes, engenheiros);
                            break;
                        }
                }
            }
        }

        static void MenuSecundario(string nome, string cpf, double salario, List<Funcionario> funcionarios, List<Gerente> gerentes, List<Engenheiro> engenheiros)
        {
            Console.Clear();
            short option = 0;
            bool optionPossible;

            System.Console.WriteLine("Qual tipo de funcionário ele é?");
            System.Console.WriteLine("1 - Funcionário Comum");
            Console.WriteLine("2 - Gerente");
            Console.WriteLine("3 - Engenheiro");
            System.Console.WriteLine("0 - Voltar ao Menu Principal");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible || option < 0 || option > 3)
            {
                Console.Clear();
                System.Console.WriteLine("Insira o valor no intervalo indicado");
                Thread.Sleep(2500);
                Menu(funcionarios, gerentes, engenheiros);
            }
            else
            {
                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();

                            Funcionario funcionario = new Funcionario(nome, cpf, salario);
                            funcionarios.Add(funcionario);
                            Console.WriteLine("O Funcionário comum já está adicionado na lista de funcionários");

                            Console.WriteLine("Dê enter para voltar ao Menu Principal!");
                            Thread.Sleep(1000);
                            Console.ReadLine();
                            Menu(funcionarios, gerentes, engenheiros);

                            break;
                        }
                    case 2:
                        {
                            Console.Clear();

                            float SenhaEspecial;
                            int quantidadeFuncionarios = funcionarios.Count() + gerentes.Count() + engenheiros.Count();
                            bool possivel;
                            do
                            {
                                Console.WriteLine("Digite uma senha para esse gerente");
                                possivel = float.TryParse(Console.ReadLine(), out SenhaEspecial);
                            } while (!possivel);

                            Gerente gerente = new Gerente(nome, cpf, salario, SenhaEspecial, quantidadeFuncionarios);

                            gerentes.Add(gerente);
                            Console.WriteLine("O Gerente já está adicionado na lista de gerentes");

                            Thread.Sleep(1000);
                            Console.WriteLine("Dê Enter para voltar ao Menu principal");
                            Console.ReadLine();
                            Menu(funcionarios, gerentes, engenheiros);

                            break;
                        }
                    case 3:
                        {
                            Console.Clear();

                            string regra = @"[0-9]{9}-[0-9]";
                            Regex regexNome = new Regex(regra);

                            string crea;
                            string categoria;
                            string projetoAtual;

                            do
                            {
                                Console.WriteLine("Digite o Crea (modelo: xxxxxxxxx-x");
                                crea = Console.ReadLine();
                            } while (!regexNome.IsMatch(crea));
                            do
                            {
                                Console.WriteLine("Digite a categoria");
                                categoria = Console.ReadLine();
                            } while (categoria.Equals(""));
                            do
                            {
                                Console.WriteLine("Digite o nome do projeto atual");
                                projetoAtual = Console.ReadLine();
                            } while (projetoAtual.Equals(""));

                            Engenheiro engenheiro = new Engenheiro(nome, cpf, salario, crea, categoria, projetoAtual);
                            engenheiros.Add(engenheiro);
                            Console.WriteLine("O Engenheiro já está adicionado na lista de engenheiros");

                            Thread.Sleep(1000);
                            Console.WriteLine("Dê Enter para voltar ao Menu principal");
                            Console.ReadLine();
                            Menu(funcionarios, gerentes, engenheiros);

                            break;
                        }
                    case 0:
                        {
                            Console.Clear();
                            Menu(funcionarios, gerentes, engenheiros);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            System.Console.WriteLine("Insira o valor no intervalo indicado");
                            Thread.Sleep(2500);
                            MenuSecundario(nome, cpf, salario, funcionarios, gerentes, engenheiros);

                            break;
                        }
                }
            }
        }

        static void BuscarFuncionario(List<Funcionario> funcionarios, List<Gerente> gerentes, List<Engenheiro> engenheiros)
        {
            Console.Clear();

            string regraNome = @"[A-ZÀ-Ÿ][A-zÀ-ÿ' ]+";
            Regex regexNome = new Regex(regraNome);
            string nomeFuncionario;

            foreach (Funcionario func in funcionarios)
            {
                Console.WriteLine($"Nome: {func.GetNome()}       Salário: {func.GetSalario()}");
            }
            foreach (Gerente g in gerentes)
            {
                Console.WriteLine($"Nome: {g.GetNome()}       Salário: {g.GetSalario()}");
            }

            foreach (Engenheiro e in engenheiros)
            {
                Console.WriteLine($"Nome: {e.GetNome()}       Salário: {e.GetSalario()}");
            }

            do
            {
                Console.WriteLine("Digite o nome do funcionário que deseja Bonificar");
                nomeFuncionario = Console.ReadLine();
            } while (!regexNome.IsMatch(nomeFuncionario));

            if (funcionarios.Exists(x => x.GetNome().Equals(nomeFuncionario)))
            {
                var f = funcionarios.Find(x => x.GetNome().Contains(nomeFuncionario));
                f.CalcularBonificacao(f);
            }
            else if (gerentes.Exists(x => x.GetNome().Equals(nomeFuncionario)))
            {
                var f = gerentes.Find(x => x.GetNome().Contains(nomeFuncionario));
                f.CalcularBonificacao(f);
            }
            else if (engenheiros.Exists(x => x.GetNome().Equals(nomeFuncionario)))
            {
                var f = engenheiros.Find(x => x.GetNome().Contains(nomeFuncionario));
                f.CalcularBonificacao(f);
            }
            else
            {
                Console.WriteLine("Esse funcionário não foi encontrado");
                Thread.Sleep(1000);
                Console.WriteLine("Dê Enter para voltar ao Menu principal");
                Console.ReadLine();
                Menu(funcionarios, gerentes, engenheiros);
            }

        }
    }
}
