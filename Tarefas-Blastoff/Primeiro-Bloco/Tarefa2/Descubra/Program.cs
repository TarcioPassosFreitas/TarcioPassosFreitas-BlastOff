using System;
using System.Runtime;

namespace Descubra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool itsPossible;
            var number_digit = 0;

            Random randomValue = new Random();
            int randomValueInt = randomValue.Next(5);
            //System.Console.WriteLine(randomValueInt); Para testar

            do
            {
                Console.Clear();
                System.Console.WriteLine("Test find the number drawn by the computer");
                System.Console.WriteLine("Enter a number between 0 and 5:");
                itsPossible = int.TryParse(Console.ReadLine(), out number_digit);
            } while (!itsPossible || number_digit < 0 || number_digit > 5);

            if (number_digit == randomValueInt)
            {
                System.Console.WriteLine("The User Win");
            }
            else
            {
                System.Console.WriteLine("The User Lose");
            }
        }
    }
}
