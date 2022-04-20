using System;

namespace Calculadora
{
    class Program
    {
        static void Main(String[] args)
        {

            Menu();

        }

        static void Menu()
        {
            Console.Clear();

            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine("1 - Soma");
            System.Console.WriteLine("2 - Subtração");
            System.Console.WriteLine("3 - Multiplicação");
            System.Console.WriteLine("4 - Divisão");
            System.Console.WriteLine("5 - Sair");

            System.Console.WriteLine("-------------------");
            System.Console.WriteLine("Selecione uma opção: ");
            short resp = short.Parse(Console.ReadLine());

            switch (resp)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: multiplicacao(); break;
                case 4: divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}");
            // Console.WriteLine($"O resultado da soma é {v1 + v2}");
            // Console.WriteLine("O resultado da soma é " + (v1 + v2));
            // Console.WriteLine("O resultado da soma é " + v1 + v2); //entende como string
            Console.ReadKey();

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void divisao()
        {
            Console.Clear();
            float v1;
            float v2;
            Console.WriteLine("Primeiro valor: ");
            v1 = float.Parse(Console.ReadLine());
            do
            {
                System.Console.WriteLine("Segundo valor: ");
                v2 = float.Parse(Console.ReadLine());
            } while (v2 == 0);
            System.Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();

            Menu();
        }
    }
}
