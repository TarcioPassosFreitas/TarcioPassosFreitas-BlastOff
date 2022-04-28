using System;
using System.Text.RegularExpressions;

namespace RendimentoPesca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu();


        }

        static void Business_rule(string unity) //Regra de negócio
        {
            System.Console.WriteLine("Welcome to the fish quantity monitoring system"); //Bem-vindo ao sistema de monitoramento de quantidade de peixes
            switch (unity)
            {
                case "t":
                    {
                        DataInput(unity); break;
                    }
                case "kg":
                    {
                        DataInput(unity); break;
                    }
                case "g":
                    {
                        System.Console.WriteLine("Amount in gram does not generate a fine"); //Quantidade em grama não gera multa
                        Thread.Sleep(2500);
                        System.Console.WriteLine("click enter to return to Menu");
                        Console.ReadLine();
                        Menu();
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Enter the value in the indicated range"); //Insira o valor no intervalo indicado
                        Thread.Sleep(2500);
                        Measurement_units();
                        break;
                    }
            }



        }

        static void Excess_calculation(double quantity, string unity) //Cálculo do excesso
        {


            if (unity == "t")
            {
                quantity = quantity * 1000; //por que não bateu os resultados?
            }

            double excesso = quantity - 50.0;
            double multa;

            if (quantity > 50)
            {
                multa = Math.Abs(excesso) * 4;
                System.Console.WriteLine($"There's excess. The excess is {Math.Abs(excesso)} {unity}. And the fine is R$: {multa:N2}");
                Thread.Sleep(2500);
                System.Console.WriteLine("click enter to return to Menu");
                Console.ReadLine();
                Menu();
            }
            else
            {
                System.Console.WriteLine("The amount of kilos is within acceptable standards"); //A quantidade de quilos está dentro dos padrões aceitáveis
                Thread.Sleep(2500);
                System.Console.WriteLine("click enter to return to Menu");
                Console.ReadLine();
                Menu();
            }
        }

        static void DataInput(string unity) //Entrada de dados
        {
            Console.Clear();
            bool is_possible_quantity; //é possível quantidade
            double quantity; //quantidade
            System.Console.WriteLine("Entre com o valor da quantidade");
            is_possible_quantity = double.TryParse(Console.ReadLine(), out quantity);
            if (!is_possible_quantity || quantity <= 0)
            {
                DataInput(unity);
            }
            else
            {
                Excess_calculation(quantity, unity);
            }

        }

        static void Measurement_units() // Opções de unidade de medida
        {
            Console.Clear();
            System.Console.WriteLine("t - to tons");
            System.Console.WriteLine("kg - to Kilogram");
            System.Console.WriteLine("g - for grass");

            string unity = Console.ReadLine().ToLower(); //unidade
            Business_rule(unity);
        }

        static void Menu()
        {
            short option = 0;
            bool optionPossible;

            Console.Clear();
            System.Console.WriteLine("Welcome to the Fishing Income System"); //Bem-vindo ao sistema de rendimento de pesca
            System.Console.WriteLine("1 - Start");
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
                    case 1: Measurement_units(); break;
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
