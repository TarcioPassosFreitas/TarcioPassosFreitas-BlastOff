using PostoGasolina.Entities;
using PostoGasolina.Enums;
using System;

namespace PostoGasolina
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
            Console.WriteLine("Bem-vindo ao Posto 2 irmãos, aqui o tratamento é diferenciado");

            BombaCombustivel fp = new BombaCombustivel();

            TiposGasolinaConsole(fp);

        }

        static void MenuSecundario(BombaCombustivel fp, TipoBomba tp)
        {
            Console.Clear();


            short option;
            bool possivel;
            do
            {
                Console.WriteLine("Você deseja:\n 1 - Trocar o tipo de combustível\n2 - Abastecer através de um valor em reais\n3 - Abastecer através da quantidade em litros\n" +
               "4 - Sair\n5 - àrea de ADM");
                possivel = short.TryParse(Console.ReadLine(), out option);
            } while (!possivel || option < 1 || option > 5);

            switch (option)
            {
                case 1: TiposGasolinaConsole(fp); break;
                case 2:
                    {
                        Console.Clear();

                        bool possivel2;
                        double valor;
                        int cont = 0;
                        do
                        {
                            cont++;
                            if (cont > 1)
                            {
                                Console.WriteLine("Entre com um valor no intervalo determinado");
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine("Digite o valor que você deseja abastecer em reais:");
                            possivel2 = double.TryParse(Console.ReadLine(), out valor);
                        } while (!possivel2 || valor < fp.GetValorLitro() || valor > 600);
                        fp.abastecerPorValor(valor);
                        Thread.Sleep(1000);
                        Console.WriteLine("Dê enter para voltar ao Menu");
                        Console.ReadLine();


                        break;

                    }
                case 3:
                    {
                        Console.Clear();

                        bool possivel2;
                        double valor;
                        int cont = 0;
                        do
                        {
                            cont++;
                            if (cont > 1)
                            {
                                Console.WriteLine("Entre com um valor no intervalo determinado");
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine("Digite o valor que você deseja abastecer em litros:");
                            possivel2 = double.TryParse(Console.ReadLine(), out valor);
                        } while (!possivel2 || valor < fp.GetValorLitro() || valor > 600);
                        fp.abastecerPorLitro(valor);
                        Thread.Sleep(1000);
                        Console.WriteLine("Dê enter para voltar ao Menu");
                        Console.ReadLine();
                        Menu();

                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                case 5:
                    {
                        Console.Clear();

                        AlterarValores(fp);

                        break;
                    }
                default:
                    {
                        MenuSecundario(fp, tp);
                        break;
                    }
            }
        }

        public static void TiposGasolinaConsole(BombaCombustivel bc)
        {

            TipoBomba tb;
            bool possivel;
            int i = 0;



            foreach (var name in Enum.GetNames(typeof(TipoBomba)))
            {
                Console.WriteLine($"{i} - {name}");
                i++;

            }

            do
            {
                Console.WriteLine("Veja os nossos tipos de combustível e digite o número correspondente ao combustível que deseja abastecer");
                possivel = Enum.TryParse<TipoBomba>(Console.ReadLine(), true, out tb);
            } while (!possivel || (int)tb < 0 || (int)tb > 4);

            MenuSecundario(bc, tb);
        }

        public static void AlterarValores(BombaCombustivel bc)
        {
            short option;
            bool possivel;

            do
            {
                Console.WriteLine("1 - Deseja alterar o valor do litro de combustível\n 2 - Deseja alterar a quantidade de combustível do posto\n");
                possivel = short.TryParse(Console.ReadLine(), out option);
            } while (!possivel || option < 1 || option > 2);

            switch (option)
            {
                case 1:
                    {
                        double valorLitro;

                        do
                        {
                            Console.WriteLine($"Digite o novo valor do litro do combustível. Atualmente tem {bc.GetValorLitro()}");
                            possivel = double.TryParse(Console.ReadLine(), out valorLitro);
                        } while (!possivel || valorLitro <= bc.GetValorLitro());

                        bc.alterarValor(valorLitro);

                        Console.WriteLine("Valor alterado");
                        Thread.Sleep(1000);
                        Console.WriteLine("Dê enter para voltar ao Menu");
                        Console.ReadLine();
                        Menu();

                        break;
                    }
                case 2:
                    {
                        double litroCombustivelBomba;

                        do
                        {
                            Console.WriteLine($"Digite o novo valor da bomba de combustível. Atualmente tem {bc.GetQuantidadeCombustivel()}");
                            possivel = double.TryParse(Console.ReadLine(), out litroCombustivelBomba);
                        } while (!possivel || litroCombustivelBomba <= bc.GetQuantidadeCombustivel());

                        bc.alterarQuantidadeCombustivelPosto(litroCombustivelBomba);

                        Console.WriteLine("Valor alterado");
                        Thread.Sleep(1000);
                        Console.WriteLine("Dê enter para voltar ao Menu");
                        Console.ReadLine();
                        Menu();

                        break;
                    }

            }

        }
    }
}