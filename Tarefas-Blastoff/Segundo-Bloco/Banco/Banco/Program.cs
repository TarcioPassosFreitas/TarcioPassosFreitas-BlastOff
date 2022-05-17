using Banco.Entities;
using System;
using System.Text.RegularExpressions;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            short option = 0;
            bool optionPossible;

            Console.Clear();
            System.Console.WriteLine("Bem-vindo ao Banco");
            System.Console.WriteLine("1 - Conta Corrente");
            Console.WriteLine("2 - Conta Poupança");
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
                            string regra1 = @"[0-9]{6}-[0-9X]";
                            Regex regex1 = new Regex(regra1);

                            string regra2 = @"[0-9]{4}";
                            Regex regex2 = new Regex(regra2);

                            string conta;
                            string agencia;
                            double saldo;
                            bool possivel;

                            do
                            {
                                Console.WriteLine("Digite a conta da conta corrente no formato 000000-0");
                                conta = Console.ReadLine();
                            }while(!regex1.IsMatch(conta));

                            do
                            {
                                Console.WriteLine("Digite a agência da conta corrente");
                                agencia = Console.ReadLine();
                            } while (!regex2.IsMatch(agencia));

                            do
                            {
                                Console.WriteLine("Digite um valor para seu saldo:" +
                                    "(Valor até 5.000");
                                possivel = double.TryParse(Console.ReadLine(), out saldo);
                            } while (!possivel || saldo < 0 || saldo > 5000);

                            Corrente cc = new Corrente(conta, agencia, saldo);

                            Console.WriteLine("Dê enter e veja seu saldo depois de pagar a mensalidade:");
                            Console.ReadLine();

                            cc.DescontaMensalidade();

                            Thread.Sleep(1000);
                            Console.WriteLine("Dê enter para voltar ao Menu");
                            Console.ReadLine();
                            Menu();
                            break;
                        }
                    case 2:
                        {
                            string regra1 = @"[0-9]{5}-[0-9X]";
                            Regex regex1 = new Regex(regra1);

                            string regra2 = @"[0-9]{4}";
                            Regex regex2 = new Regex(regra2);

                            string conta;
                            string agencia;
                            double saldo;
                            bool possivel;

                            int meses;

                            do
                            {
                                Console.WriteLine("Digite a conta da conta corrente");
                                conta = Console.ReadLine();
                            } while (!regex1.IsMatch(conta));

                            do
                            {
                                Console.WriteLine("Digite a agência da conta corrente");
                                agencia = Console.ReadLine();
                            } while (!regex2.IsMatch(agencia));

                            do
                            {
                                Console.WriteLine("Digite um valor para seu saldo:" +
                                    "(Valor até 5.000");
                                possivel = double.TryParse(Console.ReadLine(), out saldo);
                            } while (!possivel || saldo < 0 || saldo > 5000);

                            Poupanca cp = new Poupanca(conta, agencia, saldo);

                            
                            do
                            {
                                Console.WriteLine("Digite quantos meses o dinheiro ficou rendendo," +
                                    "mínimo 6 meses e máximo 30 meses");
                                possivel = int.TryParse(Console.ReadLine(), out meses);
                            } while (!possivel || meses < 6 || meses > 30);

                            Console.WriteLine("Dê enter e veja seu saldo depois de render na poupança:");
                            Console.ReadLine();

                            double rendimento = cp.CalculaRendimento(meses);

                            Console.WriteLine($"O valor do rendimento foi de R$: {rendimento:F2}");

                            Thread.Sleep(1000);
                            Console.WriteLine("Dê enter para voltar ao Menu");
                            Console.ReadLine();
                            Menu();
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
