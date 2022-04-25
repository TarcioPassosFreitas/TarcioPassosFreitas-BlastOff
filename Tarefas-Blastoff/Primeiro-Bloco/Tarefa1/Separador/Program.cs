using System;

namespace Separador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_digit;
           
            do
            {
                Console.Clear();
                number_digit = int.Parse(Console.ReadLine());
                Separate(number_digit);
            } while (number_digit < 0 || number_digit > 9999 || number_digit == null);
        }

        static void Separate(int value)
        {
            int u = value / 1 % 10;
            int d = value / 10 % 10;
            int c = value / 100 % 10;
            int uM = value / 1000 % 10;

            System.Console.WriteLine($@"
                                        {u}
                                        {d}
                                        {c}
                                        {uM}");
        }
    }
}
