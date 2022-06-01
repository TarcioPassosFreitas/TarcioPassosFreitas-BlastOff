using Museu.Entities;
using System;
using System.Text.RegularExpressions;

namespace Museu
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
            System.Console.WriteLine("Bem-vindo ao Museu");
            System.Console.WriteLine("1 - Visitante Normal");
            Console.WriteLine("2 - Visitante Premium");
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
                            string nome;
                            string cpf;
                            string nascimento;
                            byte codTema;
                            bool possivel;

                            string regra1 = @"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}";
                            Regex regex = new Regex(regra1);

                            Console.WriteLine("Digite o seu nome");
                            nome = Console.ReadLine();

                            do
                            {
                                Console.WriteLine("Digite o cpf (Formato: xxx.xxx.xxx-xx)");
                                cpf = Console.ReadLine();
                            }while(!regex.IsMatch(cpf));

                            Console.WriteLine("Digite seu ano de nascimento: (Formato: yyyy-MM-dd)");
                            nascimento = Console.ReadLine();
                            var Nascimentoformatada = string.Format("{0:yyyy-MM-dd}", nascimento);

                            Console.WriteLine("Escolha 1 tema. Eles são:\n1 - VINTAGE = 1\n2 - NUMISMATICA = 2\n" +
                                "HISTORIA_DA_MUSICA = 3\n4- PINTURAS = 5 - ESCULTURA = 5;");

                            do
                            {
                                Console.WriteLine("Escolha um código Tema");
                                possivel = byte.TryParse(Console.ReadLine(), out codTema);
                            } while (!possivel || codTema < 0 || codTema > 5);

                            Visitantes v = new Visitantes(nome, cpf, Convert.ToDateTime(Nascimentoformatada), codTema);

                            Console.Clear();
                            v.InformacaoItem();
                            Thread.Sleep(1000);
                            Console.WriteLine("Dê enter para verificar a quantidade de itens exposta");
                            Console.ReadLine();
                            v.QuantosItensExpostos();
                            Thread.Sleep(1000);
                            Console.WriteLine("Dê enter para voltar ao Menu");
                            Console.ReadLine();
                            Menu();
                            break;
                        }
                    case 2:
                        {
                            string nome;
                            string cpf;
                            string nascimento;
                            byte codTema;
                            bool possivel;

                            string regra1 = @"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}";
                            Regex regex = new Regex(regra1);

                            Console.WriteLine("Digite o seu nome");
                            nome = Console.ReadLine();

                            do
                            {
                                Console.WriteLine("Digite o cpf");
                                cpf = Console.ReadLine();
                            } while (!regex.IsMatch(cpf));

                            Console.WriteLine("Digite seu ano de nascimento:");
                            nascimento = Console.ReadLine();
                            var Nascimentoformatada = string.Format("{0:yyyy-MM-dd}", nascimento);

                            Console.WriteLine("Escolha 1 tema. Eles são:\n1 - VINTAGE = 1\n2 - NUMISMATICA = 2\n" +
                                "3 - HISTORIA_DA_MUSICA = 3\n4- PINTURAS = 4\n5 - ESCULTURA = 5;");

                            do
                            {
                                Console.WriteLine("Escolha um código Tema");
                                possivel = byte.TryParse(Console.ReadLine(), out codTema);
                            } while (!possivel || codTema < 0 || codTema > 5);

                            VisitantesPremium vp = new VisitantesPremium(nome, cpf, Convert.ToDateTime(Nascimentoformatada), codTema);

                            //Console.WriteLine("você comprou algo? quanto custou?");
                            Console.WriteLine(vp.Saldo());
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
