using System;
using System.Threading;

namespace CursoCronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //Start(6);
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("S = Segundo => 10s = 10 segundos");
            System.Console.WriteLine("M = Minuto => 1m = 1 minuto");
            System.Console.WriteLine("0 = Sair");
            System.Console.WriteLine("Quanto tempo deseja contar");

            string data = Console.ReadLine().ToLower();
            // char type = data.Substring(1,1); //1 caracter primeira posição BANANA, pegaria o A. começa do 0
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }
            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            //Start(time * multiplier);
            PreStart(time * multiplier);


            //System.Console.WriteLine(data);
            // System.Console.WriteLine(type);
            // System.Console.WriteLine(time);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            System.Console.WriteLine("Read...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Set...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
        static void Start(int time) //É o que dispara nosso cronômetro
        {
            //int time = 10;
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                System.Console.WriteLine(currentTime);
                Thread.Sleep(1000);   //Thread = execução atual Sleep = tempo que vai dormir, em milissegundos
            }
            Console.Clear();
            System.Console.WriteLine("CursoCronometro finalizado");
            Thread.Sleep(2500);

            Menu();
        }
    }
}
