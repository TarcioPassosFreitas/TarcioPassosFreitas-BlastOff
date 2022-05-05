using System;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void FuncaoPrincipal()
        {
            double length;
            double width;

            Console.WriteLine("Sistema de ajuda metragem de pisos");
            Console.WriteLine("Por favor, insira os dados do piso");

            Console.WriteLine("Insira o valor do comprimento do piso: ");
            Thread.Sleep(2500);
            Console.ReadLine();

            length = Validation();

            Console.WriteLine("Insira o valor do largura do piso: ");
            Thread.Sleep(2500);
            Console.ReadLine();

            width = Validation();

            ModelRetangle rect1 = new ModelRetangle(length, width);

            Console.Clear();

            Console.WriteLine("Por favor, insira os dados do cômodo");

            Console.WriteLine("Insira o valor do comprimento do cômodo: ");
            Thread.Sleep(2500);
            Console.ReadLine();

            length = Validation();

            Console.WriteLine("Insira o valor do largura do cômodo: ");
            Thread.Sleep(2500);
            Console.ReadLine();

            width = Validation();

            ModelRetangle rect2 = new ModelRetangle(length, width);

            Console.WriteLine("Qual o tamanho do rodapé que deseja no seu cômodo");
            Thread.Sleep(2500);

            double tamanhorodape;

            tamanhorodape = Validation();

            Bricklayer bricklayer = new Bricklayer(rect1, rect2, tamanhorodape);
            bricklayer.MethodNumberOfFloors();
            bricklayer.MethodNumberBaseBoard();




        }

        static void Menu()
        {
            short option = 0;
            bool optionPossible;

            Console.Clear();
            Console.WriteLine("Sistema de ajuda metragem de pisos");
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
                    case 1: FuncaoPrincipal(); break;
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
                            Thread.Sleep(1000);
                            Menu();
                            break;
                        }
                }
            }
        }

        static double Validation()
        {
            Console.Clear();

            double value = 0;
            bool itsPossible;
            itsPossible = double.TryParse(Console.ReadLine(), out value);

            if (!itsPossible || value <= 4 || value > 200 )
            {
                Console.WriteLine("O valor está fora do intervalo determinado. Por favor entre com um outro valor.");
                Thread.Sleep(1000);
                Console.WriteLine("Aperte enter para voltar à entrada de dados");
                Console.ReadLine();

                return Validation();
            }
            else
            {
                return value;
            }
            
        }
    }
}
