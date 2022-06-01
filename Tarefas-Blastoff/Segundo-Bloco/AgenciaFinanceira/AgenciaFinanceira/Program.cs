using AgenciaFinanceira.Entities;
using System;
using System.Text.RegularExpressions;

namespace AgenciaFinanceira
{
    internal class Program
    {
        public static Random Random = new Random();
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            short option = 0;
            bool optionPossible;

            System.Console.WriteLine("Sistema de Financiamento");
            Console.WriteLine("Que tipo de cliente você é?\n1 - Pessoa física\n2 - Pessoa jurídica");
            System.Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible || option < 0 || option > 2)
            {
                Console.Clear();
                System.Console.WriteLine("Insira o valor no intervalo indicado");
                Thread.Sleep(2500);
                Menu();
            }
            else
            {
                switch (option)
                {
                    case 1:
                        {
                            int numero = Random.Next(0, 1000);
                            string regraNome = @"[A-ZÀ-Ÿ][A-zÀ-ÿ' ]+";
                            string regraCpf = @"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}";
                            Regex regexNome = new Regex(regraNome);
                            Regex regexCpf = new Regex(regraCpf);
                            string? nomeContratante;
                            float Valor_fincanciamento;
                            int prazo;
                            string cpf;
                            int idade;
                            bool possivel;
                            do
                            {
                                Console.WriteLine("Digite o Nome do Contratante (Primeira letra Maiúscula)");
                                nomeContratante = Console.ReadLine();
                            } while (!regexNome.IsMatch(nomeContratante));
                            do
                            {
                                Console.WriteLine("Digite o valor do contrato");
                                possivel = float.TryParse(Console.ReadLine(), out Valor_fincanciamento);
                            } while (!possivel);
                            do
                            {
                                Console.WriteLine("Digite o prazo para esse financiamento em dias (Limite 3600 dias)");
                                possivel = int.TryParse(Console.ReadLine(), out prazo);
                            } while (!possivel || prazo > 3600);
                            do
                            {
                                Console.WriteLine("Digite o seu CPF no formato: xxx.xxx.xxx-xx");
                                cpf = Console.ReadLine();
                            } while (!regexCpf.IsMatch(cpf));
                            do
                            {
                                Console.WriteLine("Digite sua idade (Entre 18 e 60 anos)");
                                possivel = int.TryParse(Console.ReadLine(), out idade);
                            } while (!possivel || idade < 18 || idade > 60);
                            ContratoPessoaFisica pf = new ContratoPessoaFisica(numero, nomeContratante, Valor_fincanciamento, prazo, cpf, idade);
                            MenuPessoaFisicaOpcoes(pf);

                            break;
                        }
                    case 2:
                        {
                            int numero = Random.Next(0, 1000);
                            string regraNome = @"[A-ZÀ-Ÿ][A-zÀ-ÿ' ]+";
                            string regraCnpj = @"[0-9]{2}\.?[0-9]{3}\.?[0-9]{3}\/?[0-9]{4}\-?[0-9]{2}";
                            string regraNumIncricao = @"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}";
                            Regex regexNome = new Regex(regraNome);
                            Regex regexCnpj = new Regex(regraCnpj);
                            Regex regexNumIncricao = new Regex(regraNumIncricao);
                            string numIncricao;
                            string? nomeContratante;
                            float Valor_fincanciamento;
                            int prazo;
                            string cnpj;
                            bool possivel;
                            do
                            {
                                Console.WriteLine("Digite o Nome da Contratante (Primeira letra maiúscula)");
                                nomeContratante = Console.ReadLine();
                            } while (!regexNome.IsMatch(nomeContratante) || nomeContratante.Equals(""));
                            do
                            {
                                Console.WriteLine("Digite o Número de inscrição da sua empresa (formato: xxx.xxx.xxx)");
                                numIncricao = Console.ReadLine();
                            } while (!regexNumIncricao.IsMatch(numIncricao) || numIncricao.Equals(""));
                            do
                            {
                                Console.WriteLine("Digite o valor do contrato");
                                possivel = float.TryParse(Console.ReadLine(), out Valor_fincanciamento);
                            } while (!possivel);
                            do
                            {
                                Console.WriteLine("Digite o prazo para esse financiamento em dias(Máximo 3600 dias)");
                                possivel = int.TryParse(Console.ReadLine(), out prazo);
                            } while (!possivel || prazo > 3600);
                            do
                            {
                                Console.WriteLine("Digite a sua CNPJ no formato: XX.XXX.XXX/0001-XX");
                                cnpj = Console.ReadLine();
                            } while (!regexCnpj.IsMatch(cnpj));
                            ContratoPessoaJuridica pj = new ContratoPessoaJuridica(numero, nomeContratante, Valor_fincanciamento, prazo, cnpj, numIncricao);
                            MenuPessoaJuridicaOpcoes(pj);

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

        static void MenuPessoaFisicaOpcoes(ContratoPessoaFisica pf)
        {
            Console.Clear();
            short option = 0;
            bool optionPossible;

            Console.WriteLine("O que deseja fazer");
            Console.WriteLine("1 - Calcular Prestação");
            Console.WriteLine("2 - Exibir Informações");
            Console.WriteLine("3 - calcular Prestação Polimórfico");
            Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible || option < 0 || option > 3)
            {
                Console.Clear();
                Console.WriteLine("Insira o valor no intervalo indicado");
                Thread.Sleep(2500);
                Menu();
            }
            else
            {
                switch (option)
                {
                    case 1:
                        {
                            pf.calcularPrestacao();
                            Console.WriteLine("O valor da prestação foi calculada");
                            Thread.Sleep(1000);
                            Console.WriteLine("Dê um enter para voltar ao menu Pessoa física");
                            Console.ReadLine();
                            MenuPessoaFisicaOpcoes(pf);
                            break;
                        }
                    case 2:
                        {
                            pf.exibirInfo();
                            Thread.Sleep(1000);
                            Console.WriteLine("Dê um enter para voltar ao menu Pessoa física");
                            Console.ReadLine();
                            MenuPessoaFisicaOpcoes(pf);
                            break;
                        }
                    case 3:
                        {
                            pf.calcularPrestacaoPolimorfico(pf);
                            Console.WriteLine("O valor da prestação foi calculada");
                            Thread.Sleep(1000);
                            Console.WriteLine("Dê um enter para voltar ao menu Pessoa física");
                            Console.ReadLine();
                            MenuPessoaFisicaOpcoes(pf);
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
                            Console.WriteLine("Voltando ao Menu Principal");
                            Thread.Sleep(2500);
                            Menu();
                            break;
                        }
                }
            }
        }

        static void MenuPessoaJuridicaOpcoes(ContratoPessoaJuridica pj)
        {
            Console.Clear();
            short option = 0;
            bool optionPossible;

            Console.WriteLine("O que deseja fazer");
            Console.WriteLine("1 - Calcular Prestação");
            Console.WriteLine("2 - Exibir Informações");
            Console.WriteLine("3 - calcular Prestação Polimórfico");
            Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible || option < 0 || option > 3)
            {
                Console.Clear();
                Console.WriteLine("Insira o valor no intervalo indicado");
                Thread.Sleep(2500);
                Menu();
            }
            else
            {
                switch (option)
                {
                    case 1:
                        {
                            pj.calcularPrestacao();
                            Console.WriteLine("O valor da prestação foi calculada");
                            Thread.Sleep(1000);
                            Console.WriteLine("Dê um enter para voltar ao menu Pessoa Jurídica");
                            Console.ReadLine();
                            MenuPessoaJuridicaOpcoes(pj);
                            break;
                        }
                    case 2:
                        {
                            pj.exibirInfo();
                            Thread.Sleep(1000);
                            Console.WriteLine("Dê um enter para voltar ao menu Pessoa Jurídica");
                            Console.ReadLine();
                            MenuPessoaJuridicaOpcoes(pj);
                            break;
                        }
                    case 3:
                        {
                            pj.calcularPrestacaoPolimorfico(pj);
                            Console.WriteLine("O valor da prestação foi calculada");
                            Thread.Sleep(1000);
                            Console.WriteLine("Dê um enter para voltar ao menu Pessoa Jurídica");
                            Console.ReadLine();
                            MenuPessoaJuridicaOpcoes(pj);
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
                            Console.WriteLine("Voltando ao Menu Principal");
                            Thread.Sleep(2500);
                            Menu();
                            break;
                        }
                }
            }
        }
    }
}
