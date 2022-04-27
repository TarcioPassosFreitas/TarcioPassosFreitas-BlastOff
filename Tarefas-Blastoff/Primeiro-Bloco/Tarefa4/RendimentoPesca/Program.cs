using System;
using System.Text.RegularExpressions;

namespace RendimentoPesca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the fish quantity monitoring system");
            Menu();


        }

        static void regraNegocio(String unidade)
        {

            switch (unidade)
            {
                case "t":
                    {
                        MenuTerciario(unidade); break;
                    }
                case "kg":
                    {
                        MenuTerciario(unidade); break;
                    }
                case "g":
                    {
                        System.Console.WriteLine("Quantidade em grama não gera multa");
                        Thread.Sleep(2500);
                        MenuSecundario();
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Enter thevalue in the indicated range");
                        System.Console.WriteLine("Digite o valor da unidade novamente");
                        Thread.Sleep(2500);
                        MenuSecundario();
                        break;
                    }
            }



        }

        static void regraNegocio2(double quantidade, string unidade)
        {


            if (unidade == "t")
            {
                quantidade = quantidade * 1000;
            }

            double excesso = quantidade - 50.0;
            double multa;

            if (quantidade > 50)
            {
                multa = Math.Abs(excesso) * 4;
                System.Console.WriteLine($"Tem excesso. O excesso é de {Math.Abs(excesso)} {unidade}. E a multa é de R$: {multa:N2}");
            }
            else
            {
                System.Console.WriteLine("A quantidade de quilos está dentro dos padrões aceitáveis");
            }
        }

        static void MenuTerciario(string unidade)
        {
            Console.Clear();
            bool quantidadePossible;
            double quantidade;
            System.Console.WriteLine("Entre com o valor da quantidade");
            quantidadePossible = double.TryParse(Console.ReadLine(), out quantidade);
            if (!quantidadePossible || quantidade <= 0)
            {
                MenuTerciario(unidade);
            }
            else
            {
                regraNegocio2(quantidade, unidade);
            }

        }

        static void MenuSecundario()
        {
            Console.Clear();
            System.Console.WriteLine("t - Para toneladas");
            System.Console.WriteLine("kg - Para Quilograma");
            System.Console.WriteLine("g - Para grama");

            string unidade = Console.ReadLine().ToLower();
            regraNegocio(unidade);
        }

        static void Menu()
        {
            short option = 0;
            bool optionPossible;

            Console.Clear();
            System.Console.WriteLine("welcome to the system of forming triangles");
            System.Console.WriteLine("1 - Start System");
            System.Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible)
            {
                Console.Clear();
                System.Console.WriteLine("Enter the value in the indicated range");
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
                            System.Console.WriteLine("Enter thevalue in the indicated range");
                            Thread.Sleep(2500);
                            Menu();
                            break;
                        }
                }
            }
        }
    }
}
