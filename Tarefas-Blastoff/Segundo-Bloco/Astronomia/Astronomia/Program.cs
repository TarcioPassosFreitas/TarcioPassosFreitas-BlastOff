using Astronomia.Entities;
using Astronomia.Enums;
using System;
using System.Text.RegularExpressions;

namespace Astronomia
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
            System.Console.WriteLine("Bem-vindo ao Mapeando o Universo");
            System.Console.WriteLine("1 - Insira Valores");
            System.Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible || option < 0 || option > 1)
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
                    case 1: MenuSecundario(); break;
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

        static void MenuSecundario()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor de 6 Corpos celestes");
            
            
            int tipoCorpo;
            bool possivel;
            List<CorpoCeleste> list = new List<CorpoCeleste>();
            for (int i = 0; i < 6; i++)
            {

                Console.Clear();
                do
                {
                    Console.WriteLine("Você deve escolher entre\n " +
                    "0 - Asteroides\n1 - Planetas\n2 - Nebulosas\nQualquer outro valor digitado será" +
                    " automaticamente Nebulosa");
                    possivel = int.TryParse(Console.ReadLine(), out tipoCorpo);
                } while (!possivel);
                switch (tipoCorpo)
                {
                    case 0:
                        {
                            Console.WriteLine("Você escolheu o tipo Asteroide");
                            list.Add(MassaTamanhoAsteroide(tipoCorpo));
                            break;
                        }

                    case 1:
                        {
                            Console.WriteLine("Você escolheu o tipo Planeta");
                            list.Add(MassaTamanhoPlaneta(tipoCorpo));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Você escolheu o tipo Nebulosa");
                            tipoCorpo = 2;
                            list.Add(MassaTamanhoNebulosa(tipoCorpo));
                            break;
                        }
                }
            }

            Tela(list);
            Thread.Sleep(1000);
            Console.WriteLine("Pressione enter para voltar ao menu");
            Console.ReadLine();
            Menu();


        }

        static CorpoCeleste MassaTamanhoAsteroide(int tipoCorpo)
        {
            string regra = @"[A-Z0-9]+";
            Regex regex = new Regex(regra);
            string nome = "";
            double massa;
            int ordem;
            double tamanho;
            bool possivel;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o Valor da massa:" +
                    "(Parte inteira entre 7 e 1100)");
                possivel = double.TryParse(Console.ReadLine(), out massa);
            } while (!possivel || massa < 7 || massa >1100);
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o Valor da ordem da massa:" +
                    "(Deve estar entre 20 e 30");
                possivel = int.TryParse(Console.ReadLine(), out ordem);
            } while (!possivel || ordem < 20 || ordem > 30);
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o Valor do tamanho:" +
                    "(Em KM entre 0.001 e 1100)");
                possivel = double.TryParse(Console.ReadLine(), out tamanho);
            } while (!possivel || tamanho > 1100 || tamanho < 0.001);
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do asteroide: (Regra: Letra Maiúscula + letra minúscula + número)");
                nome = Console.ReadLine();
            } while (!regex.IsMatch(nome));

            CorpoCeleste cp = new CorpoCeleste(massa * Math.Pow(10, ordem), tamanho, (Tipos)tipoCorpo, nome);
            return cp;
        }

        static CorpoCeleste MassaTamanhoPlaneta(int tipoCorpo)
        {
            string regra = @"[a-z0-9]+";
            Regex regex = new Regex(regra);
            string nome = "";
            double massa;
            int ordem;
            double tamanho;
            bool possivel;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o Valor da massa:" +
                    "(Parte inteira entre 7 e 1100)");
                possivel = double.TryParse(Console.ReadLine(), out massa);
            } while (!possivel || massa > 1100 || massa < 7);
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o Valor da ordem da massa:" +
                    "(Deve estar entre 20 e 30");
                possivel = int.TryParse(Console.ReadLine(), out ordem);
            } while (!possivel || ordem > 30 || ordem < 20);
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o Valor do tamanho:" +
                    "(Em KM - entre 4.860 e 142.984)");
                possivel = double.TryParse(Console.ReadLine(), out tamanho);
            } while (!possivel || tamanho < 4.860  || tamanho > 142.984);
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do Planeta: (Regra: Letra Maiúscula + letra minúscula + número)");
                nome = Console.ReadLine();
            } while (!regex.IsMatch(nome));

            CorpoCeleste cp = new CorpoCeleste(massa * Math.Pow(10, ordem), tamanho, (Tipos)tipoCorpo, nome);
            return cp;
        }

        static CorpoCeleste MassaTamanhoNebulosa(int tipoCorpo)
        {
            string regra = @"[a-z0-9]+";
            Regex regex = new Regex(regra);
            string nome = "";
            double massa;
            int ordem;
            double tamanho;
            bool possivel;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o Valor da massa:" +
                    "(Parte inteira, quantas vezes a massa do sol?" +
                    "Valores entre 0.008 e 400 vezes a massa do sol)");
                possivel = double.TryParse(Console.ReadLine(), out massa);
            } while (!possivel || massa > 400 || massa < 0.008);
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o Valor do tamanho:" +
                    "(Em Anos-luz - entre 30 e 200)");
                possivel = double.TryParse(Console.ReadLine(), out tamanho);
            } while (!possivel || tamanho < 30 || tamanho > 200);
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o nome da Nebulosa: (Regra: Letra Maiúscula + letra minúscula + número)");
                nome = Console.ReadLine();
            } while (!regex.IsMatch(nome));

            CorpoCeleste cp = new CorpoCeleste(new CorpoCeleste().ValorMassaNebulosa(massa), new CorpoCeleste().ValorTamanhoNebulosa(tamanho), (Tipos)tipoCorpo, nome);
            return cp;
        }

        static void Tela(List<CorpoCeleste> cp)
        {
            Console.Clear();
            foreach (CorpoCeleste c in cp)
            {
                Console.WriteLine(c.GetTipo());
            }
        }
    }
}