using System;
using System.Runtime;

namespace Descubra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O sistema é um jogo onde o usuário tenta acertar o valor sorteado pelo computador no range de 0 a 5
            Menu();
        }

        static void WinLose(int number_digit, int randomValueInt) //Função para verificar se o usuário vendeu ou perdeu
        {
            //Thread.Sleep(2500);
            Console.Clear();
            if (number_digit == randomValueInt)
            {
                System.Console.WriteLine("The User Win");
            }
            else
            {
                System.Console.WriteLine("The User Lose");
            }
        }

        static void Validation()
        {
            var number_digit = 0;
            bool itsPossible;
            Random randomValue = new Random();
            int randomValueInt = randomValue.Next(5);

            Console.Clear();
            System.Console.WriteLine("Test find the number drawn by the computer"); //Teste encontre o número sorteado pelo computador
            System.Console.WriteLine("Enter a number between 0 and 5:"); //Digite um número entre 0 e 5
            itsPossible = int.TryParse(Console.ReadLine(), out number_digit);
            if (!itsPossible || number_digit < 0 || number_digit > 5)
            {
                Console.Clear();
                System.Console.WriteLine("Enter the value in the indicated range"); //Insira o valor no intervalo indicado
                Thread.Sleep(2500);
                Validation();
            }
            else
            {
                WinLose(number_digit, randomValueInt);
            }
            Thread.Sleep(2500);
            System.Console.WriteLine("Hit enter to go back to the menu"); //Aperte enter para voltar ao menu
            Console.ReadLine();
            Menu();
        }

        static void Menu()
        {
            short option = 0;
            bool optionPossible;

            Console.Clear();
            System.Console.WriteLine("Welcome to Discover Game!"); //Bem-vindo ao Discover Game!
            System.Console.WriteLine("1 - Start");
            System.Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible)
            {
                Console.Clear();
                System.Console.WriteLine("Enter the value in the indicated range"); //Insira o valor no intervalo indicado
                Thread.Sleep(2500);
                Menu();
            }
            else
            {
                switch (option)
                {
                    case 1: Validation(); break;
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
                            Thread.Sleep(2500);
                            Menu();
                            break;
                        }
                }
            }
        }
    }
}
