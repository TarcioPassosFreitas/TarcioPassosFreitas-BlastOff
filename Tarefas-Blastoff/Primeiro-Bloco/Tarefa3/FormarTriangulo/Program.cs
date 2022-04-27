using System.Text.RegularExpressions;
using System;

namespace FormarTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void SideValues()
        {
            double straight_a = 0.0;
            double straight_b = 0.0;
            double straight_c = 0.0;

            // Regex ruleABC = new Regex(@"^([0-9]*)\.([0-9]*)$");

            bool aPossible;
            bool bPossible;
            bool cPossible;

            Console.Clear();
            System.Console.WriteLine("Enter the values ​​of the three lines");
            do
            {
                System.Console.WriteLine("enter the value of the line 'a'");
                aPossible = double.TryParse(Console.ReadLine(), out straight_a);
            } while (!aPossible || straight_a < 0);

            do
            {
                System.Console.WriteLine("enter the value of the line 'b'");
                bPossible = double.TryParse(Console.ReadLine(), out straight_b);
            } while (!bPossible || straight_b < 0);

            do
            {
                System.Console.WriteLine("enter the value of the line 'c'");
                cPossible = double.TryParse(Console.ReadLine(), out straight_c);
            } while (!cPossible || straight_c < 0);

            Form_triangle(straight_a, straight_b, straight_c);
        }

        static void Form_triangle(double straight_a, double straight_b, double straight_c)
        {
            Console.Clear();
            if (straight_a < straight_b + straight_c && straight_b < straight_a + straight_c && straight_c < straight_a + straight_b)
            {
                System.Console.WriteLine("Os segmentos acima podem formar triângulo");
            }
            else
            {
                System.Console.WriteLine("Os segmentos acima, não podem formar triângulo");
            }
            Thread.Sleep(2500);
            Menu();
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
