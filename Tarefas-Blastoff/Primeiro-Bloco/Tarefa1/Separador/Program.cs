using System;

namespace Separador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool itsPossible;
            var number_digit = 0;

            do
            {
                Console.Clear();
                System.Console.WriteLine("Enter a number between 0 and 9999:");
                itsPossible = int.TryParse(Console.ReadLine(), out number_digit);
            } while (!itsPossible || number_digit < 0 || number_digit > 9999);

            Separate(number_digit);
        }

        static void Separate(int value)
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
        }
    }
}
