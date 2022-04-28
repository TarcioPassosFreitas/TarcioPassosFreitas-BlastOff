using System.Text.RegularExpressions;
using System;

namespace FormarTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa responsável por receber 3 valores de retas e dizer se pode formar triângulo ou não
            Menu();
        }

        static void SideValues() //Entrada de valores
        {
            double straight_a = 0.0;
            double straight_b = 0.0;
            double straight_c = 0.0;

            bool aPossible;
            bool bPossible;
            bool cPossible;

            Console.Clear();
            System.Console.WriteLine("Enter the values ​​of the three lines"); //Insira os valores das três linhas
            do
            {
                System.Console.WriteLine("enter the value of the line 'a'");
                aPossible = double.TryParse(Console.ReadLine(), out straight_a); //digite o valor da linha 'a'
            } while (!aPossible || straight_a < 0);

            do
            {
                System.Console.WriteLine("enter the value of the line 'b'"); //digite o valor da linha 'b'
                bPossible = double.TryParse(Console.ReadLine(), out straight_b);
            } while (!bPossible || straight_b < 0);

            do
            {
                System.Console.WriteLine("enter the value of the line 'c'"); //digite o valor da linha 'c'
                cPossible = double.TryParse(Console.ReadLine(), out straight_c);
            } while (!cPossible || straight_c < 0);

            Form_triangle(straight_a, straight_b, straight_c); //Regra de negócio. forma triângulo ou não?
        }

        static void Form_triangle(double straight_a, double straight_b, double straight_c) //Função forma triângulo
        {
            Console.Clear();
            if (straight_a < straight_b + straight_c && straight_b < straight_a + straight_c && straight_c < straight_a + straight_b)
            {
                System.Console.WriteLine("The segments above can form triangle"); //Os segmentos acima podem formar triângulo
            }
            else
            {
                System.Console.WriteLine("The segments above cannot form a triangle"); //Os segmentos acima, não podem formar triângulo
            }
            Thread.Sleep(2500);
            System.Console.WriteLine("click enter to return to Menu");
            Console.ReadLine();
            Menu();
        }

        static void Menu()
        {
            short option = 0;
            bool optionPossible;

            Console.Clear();
            System.Console.WriteLine("welcome to the system of forming triangles"); //bem-vindo ao sistema de formação de triângulos
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
                    case 1: SideValues(); break;
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
