using PostoGasolina.Entities;
using PostoGasolina.Enums;
using System;

namespace PostoGasolina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FuelPump fp = new FuelPump();

            //string name = "GNVvfr";
            //TypePump tp;
            //bool possivel = Enum.TryParse<TypePump>(name, true, out tp);
            //if (possivel)
            //{
            //    Console.WriteLine(tp.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("drogaaaa");
            //}

            ////fp.TiposGasolinaConsole();
            Menu();
            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao Posto 2 irmãos, aqui o tratamento é diferenciado");
            Console.WriteLine("Veja os nossos tipos de combustível e digite o nome correspondente ao combustível que deseja abastecer");

            TypePump tp;
            
            FuelPump fp = new FuelPump();

            TiposGasolinaConsole();
            bool possivel = Enum.TryParse<TypePump>(Console.ReadLine(), true, out tp);
            if (!possivel || (int)tp < 0 || (int)tp > 4)
            {
                Console.WriteLine("Entre com um valor no intervalo determinado");
                Thread.Sleep(1000);
                Console.WriteLine("Dê enter para voltar ao Menu");
                Console.ReadLine();
          
                Menu();
            }

            fp.InserirCombustivel(tp);
            Console.WriteLine(tp.ToString());
            Thread.Sleep(1000);
            

            MenuSecundario(fp, tp);

            

        }

        static void MenuSecundario(FuelPump fp, TypePump tp)
        {
            Console.Clear();
            Console.WriteLine("Você deseja:\n 1 - Trocar o tipo de combustível\n2 - Abastecer através de um valor em reais\n3 - Abastecer através da quantidade em litros\n" +
                "4 - Sair\n5 - àrea de ADM");
            bool possivel = int.TryParse(Console.ReadLine(), out var condicao);
            switch (condicao)
            {
                case 1: Menu(); break;
                case 2:
                    {
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
                        Console.WriteLine("1 - Deseja alterar o valor do litro de combustível\n 2 - Deseja alterar a quantidade de combustível do posto\n");
                        int 
                        break;
                    }
                default:
                    {
                        MenuSecundario(fp, tp);
                        break;
                    }
            }
        }

        public static void TiposGasolinaConsole()
        {
            int i = 0;
            foreach (var name in Enum.GetNames(typeof(TypePump)))
            {
                Console.WriteLine($"{i} - {name}");
                i++;
            }

        }


    }
}