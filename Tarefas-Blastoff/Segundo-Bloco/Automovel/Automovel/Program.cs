using Automovel.Entities;
using System;
using System.Text.RegularExpressions;

namespace Automovel
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
            System.Console.WriteLine("Venha ver os carros");
            System.Console.WriteLine("1 - Carro comum");
            Console.WriteLine("2 - Carro de luxo");
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
                            string regra = @"[A-Za-z]{3}-[0-9]{4}";
                            Regex regex = new Regex(regra);

                            string placa;
                            string modelo;
                            byte combustivel;
                            bool possivel;
                            string cor;
                            short ano;

                            do
                            {
                                Console.WriteLine("Digite a placa do carro");
                                placa = Console.ReadLine();

                            } while (!regex.IsMatch(placa));

                            Console.WriteLine("Digite o modelo");
                            modelo = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Digite o combustível que utiliza no carro:\n" +
                                    "1 - Gasolina\n2 - Alcool\n3 - Diesel\n4 - Gas");
                                possivel = byte.TryParse(Console.ReadLine(), out combustivel);
                            } while (!possivel || combustivel < 1 || combustivel > 4);

                            Console.WriteLine("Digite uma cor para o carro");
                            cor = Console.ReadLine();

                            do
                            {
                                Console.WriteLine("Digite o ano do carro");
                                possivel = short.TryParse(Console.ReadLine(), out ano);
                            } while (!possivel || ano < 1990 || ano > 2022);

                            AutomovelPadrao ap = new AutomovelPadrao(placa, modelo, combustivel, cor, ano);

                            Console.Clear();
                            Console.WriteLine("Veja o custo com base no tipo de combustível");
                            ap.QuantoCusta();

                            Thread.Sleep(1000);
                            Console.WriteLine("Dê enter para voltar ao Menu");
                            Console.ReadLine();
                            Menu();
                            break;
                        }
                    case 2:
                        {
                            string regra = @"[A-Za-z]{3}-[0-9]{4}";
                            Regex regex = new Regex(regra);

                            string placa;
                            string modelo;
                            byte combustivel;
                            bool possivel;
                            string cor;
                            short ano;

                            do
                            {
                                Console.WriteLine("Digite a placa do carro");
                                placa = Console.ReadLine();

                            } while (!regex.IsMatch(placa));

                            Console.WriteLine("Digite o modelo");
                            modelo = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Digite o combustível que utiliza no carro:\n" +
                                    "1 - Gasolina\n2 - Alcool\n3 - Diesel\n4 - Gas");
                                possivel = byte.TryParse(Console.ReadLine(), out combustivel);
                            } while (!possivel || combustivel < 1 || combustivel > 4);

                            Console.WriteLine("Digite uma cor para o carro");
                            cor = Console.ReadLine();

                            do
                            {
                                Console.WriteLine("Digite o ano do carro");
                                possivel = short.TryParse(Console.ReadLine(), out ano);
                            } while (!possivel || ano < 1990 || ano > 2022);
                            
                            Luxo cl = new Luxo(placa, modelo, combustivel, cor, ano);

                            Console.Clear();

                            Console.WriteLine("Adicionando ar condicionado:");
                            cl.adicionarArCondicionado();
                            Console.WriteLine("Adicionando Direção Hidráulica");
                            cl.direcaoHidraulica();
                            Console.WriteLine("Adicionando vidro elétrico");
                            cl.vidroEletrico();

                            cl.QuantoCusta();

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
