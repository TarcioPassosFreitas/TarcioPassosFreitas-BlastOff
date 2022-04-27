using System;

namespace CompetirSalto // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bem-vindo ao sistema de competição de saltos");
            string name = Console.ReadLine();
            int numero_saltos = 5;
            double[] saltos = new double[5];
            double menor_salto;
            double maior_salto;
            double soma_saltos = 0;
            double media_saltos;
            for (int i = 1; i <= numero_saltos; i++)
            {
                System.Console.WriteLine($"Digite o valor do salto {i}");
                saltos[i - 1] = double.Parse(Console.ReadLine());
            }

            menor_salto = saltos[0];
            maior_salto = saltos[0];

            foreach (double a in saltos)
            {
                if (menor_salto > a)
                {
                    menor_salto = a;
                }
                if (maior_salto < a)
                {
                    maior_salto = a;
                }
                soma_saltos += a;
            }

            media_saltos = soma_saltos / 5;

            System.Console.WriteLine($"Atleta: {name}");

            System.Console.WriteLine($"Primeiro Salto: {saltos[0]} m");
            System.Console.WriteLine($"Primeiro Salto: {saltos[1]} m");
            System.Console.WriteLine($"Primeiro Salto: {saltos[2]} m");
            System.Console.WriteLine($"Primeiro Salto: {saltos[3]} m");
            System.Console.WriteLine($"Primeiro Salto: {saltos[4]} m");
            System.Console.WriteLine("");
            System.Console.WriteLine($"Melhor Salto: {maior_salto} m");
            System.Console.WriteLine($"Pior Salto: {maior_salto} m");
            System.Console.WriteLine($"Média dos demais saltos: {media_saltos} m");
        }
    }
}
