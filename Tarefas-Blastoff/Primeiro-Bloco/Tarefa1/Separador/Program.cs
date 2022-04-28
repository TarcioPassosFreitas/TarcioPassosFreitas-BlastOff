using System;

namespace Separador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa responsável por separar o número em unidade, dezena, centena e unidade de milhar. Contém tratamento de erro

            Menu();
        }

        static void DataInput() //Função para entrada de dados
        {
            bool itsPossible; // é possível passar o valor digitado para inteiro
            int number_digit = 0; //Número digitado

            Console.Clear();
            System.Console.WriteLine("Enter a number between 0 and 9999:"); //Digite um número entre 0 e 9999
            itsPossible = int.TryParse(Console.ReadLine(), out number_digit);
            if (!itsPossible || number_digit < 0 || number_digit > 9999) //caso não atenda, volta a chamada a função
            {
                DataInput();
            }
            else
            {
                Separate(number_digit);
            }
        }

        static void Separate(int value) //Função para separar unidades
        {
            Console.Clear();
            int u = value / 1 % 10;
            int d = value / 10 % 10;
            int c = value / 100 % 10;
            int uM = value / 1000 % 10;

            System.Console.WriteLine($@"
            Unidade           =   {u}
            Dezena            =   {d}
            Centena           =   {c}
            Unidade de milhar =   {uM}");

            Thread.Sleep(2500);
            System.Console.WriteLine("Click enter to return to Menu!"); //Clique no enter para voltar ao Menu
            Console.ReadLine();
            Menu();
        }

        static void Menu()
        {
            short option = 0; //Opção do menu
            bool optionPossible; // é possível passar o valor digitado para short

            Console.Clear();
            System.Console.WriteLine("Welcome to the number breaker!"); //Bem-vindo ao separador de números
            System.Console.WriteLine("1 - Start");
            System.Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible)
            {
                Console.Clear();
                System.Console.WriteLine("Enter the value in the indicated range"); //Insira o valor no intervalo indicado
                Thread.Sleep(2500); //tempo na tela de 2500 milissegundos
                Menu();
            }
            else
            {
                switch (option)
                {
                    case 1: DataInput(); break;
                    case 0:
                        {
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            System.Console.WriteLine("Enter the value in the indicated range"); //Insira o valor no intervalo indicado
                            Thread.Sleep(2500); //tempo na tela de 2500 milissegundos
                            Menu();
                            break;
                        }
                }
            }
        }
    }
}
