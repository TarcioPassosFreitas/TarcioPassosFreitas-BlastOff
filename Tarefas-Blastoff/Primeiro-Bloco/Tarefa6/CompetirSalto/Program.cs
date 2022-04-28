using System.Numerics;
using System;
using System.Text.RegularExpressions;

namespace CompetirSalto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu(); //Lembrar de commitar
        }

        static void Inserir_vetor(string nome)
        {
            int numero_saltos = 5;
            bool valor_possivel;
            double[] saltos = new double[5];
            for (int i = 1; i <= numero_saltos; i++)
            {
                do
                {
                    System.Console.WriteLine($"Digite o valor do salto {i}");
                    valor_possivel = double.TryParse(Console.ReadLine(), out saltos[i - 1]);
                } while (!valor_possivel || saltos[i - 1] < 0);
            }

            RegraNegocio(saltos, nome);
        }

        static void RegraNegocio(double[] vetor, string nome)
        {
            double menor_salto;
            double maior_salto;
            double soma_saltos = 0;
            double media_saltos;

            menor_salto = vetor[0];
            maior_salto = vetor[0];

            foreach (double a in vetor)
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

            Visualizar(vetor, nome, menor_salto, maior_salto, media_saltos);


        }

        static void Visualizar(double[] vetor, string nome, double menor_salto, double maior_salto, double media_saltos)
        {
            System.Console.WriteLine($"Atleta: {nome}");

            System.Console.WriteLine($"Primeiro Salto: {vetor[0]} m");
            System.Console.WriteLine($"Segundo Salto: {vetor[1]} m");
            System.Console.WriteLine($"Terceiro Salto: {vetor[2]} m");
            System.Console.WriteLine($"Quarto Salto: {vetor[3]} m");
            System.Console.WriteLine($"Quinto Salto: {vetor[4]} m");
            System.Console.WriteLine("");
            System.Console.WriteLine($"Melhor Salto: {maior_salto} m");
            System.Console.WriteLine($"Pior Salto: {menor_salto} m");
            System.Console.WriteLine($"Média dos demais saltos: {media_saltos} m");
            Thread.Sleep(2500);
            System.Console.WriteLine("click enter to return to Menu");
            Console.ReadLine();
            Menu();
        }

        static void validarNome()
        {
            string nome = "";
            Console.Clear();
            System.Console.WriteLine("Digite o Nome do Atleta");
            string regra = @"^[A-ZÇÉÈÊÚÙÛÍÌÎÓÒÔÕÁÀÂÃ][a-zçéèêúùûíìîóòôõáàâã]+( [A-ZÇÉÈÊÚÙÛÍÌÎÓÒÔÕÁÀÂÃ][a-zçéèêúùûíìîóòôõáàâã]+)+";
            Regex regex = new Regex(regra);
            nome = Console.ReadLine();
            if (!regex.IsMatch(nome)) //coloquei uma !
            {
                validarNome();
            }
            Inserir_vetor(nome);
        }
        static void Menu()
        {
            short option = 0;
            bool optionPossible;

            Console.Clear();
            System.Console.WriteLine("Bem-vindo ao sistema de competição de saltos");
            System.Console.WriteLine("1 - Start");
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
                    case 1: validarNome(); break;
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
