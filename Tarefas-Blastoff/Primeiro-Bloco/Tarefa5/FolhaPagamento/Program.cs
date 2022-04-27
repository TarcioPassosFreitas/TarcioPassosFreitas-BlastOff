using System;

namespace FolhaPagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void coletaInformacoes()
        {
            Valor_hora();
        }

        static void RegraNegocio(double valor_hora, double horas_mes)
        {
            double salario_bruto;

            salario_bruto = (valor_hora * horas_mes);
            Console.Clear();
            System.Console.WriteLine($"Salário Bruto: ({valor_hora} * {horas_mes}) : R$: {salario_bruto:F2}");
            DescontoIr(salario_bruto);
            DescontoINSS(salario_bruto);
            double z = DescontoFGTS(salario_bruto);
            double k = DescontoSindicato(salario_bruto);
            double total_descontos = z + k;
            double salario_liquido = salario_bruto - total_descontos;
            System.Console.WriteLine($"Total de descontos: R$: {total_descontos:F2}");
            System.Console.WriteLine($"Salário Líquido: R$: {salario_liquido:F2}");


        }

        static double DescontoSindicato(double salario_bruto)
        {
            string taxa_Sindicato = "3%";
            double valor_taxa_sindicato = 0.0;
            valor_taxa_sindicato = (salario_bruto * 0.03);
            System.Console.WriteLine($"Sindicato ({taxa_Sindicato}): R$: {valor_taxa_sindicato:F2}");
            return valor_taxa_sindicato;
        }

        static double DescontoFGTS(double salario_bruto)
        {
            string taxa_FGTS = "11%";
            double valor_taxa_FGTS = 0.0;
            valor_taxa_FGTS = (salario_bruto * 0.11);
            System.Console.WriteLine($"FGTS ({taxa_FGTS}): R$: {valor_taxa_FGTS:F2}");
            return valor_taxa_FGTS;
        }

        static void DescontoINSS(double salario_bruto)
        {
            string taxa_INSS = "10%";
            double valor_taxa_INSS = 0.0;
            valor_taxa_INSS = (salario_bruto * 0.1);
            System.Console.WriteLine($"(-) INSS ({taxa_INSS}): R$: {valor_taxa_INSS:F2}");
        }

        static void DescontoIr(double salario_bruto)
        {
            string taxa_IR;
            double valor_taxa_IR = 0.0;
            if (salario_bruto >= 0 && salario_bruto <= 900)
            {
                taxa_IR = "0%";
                System.Console.WriteLine($"(-) IR ({taxa_IR}): R$: {0:F2}");
            }
            else if (salario_bruto > 900 && salario_bruto <= 1500)
            {
                taxa_IR = "5%";
                valor_taxa_IR = (salario_bruto * 0.05);
                System.Console.WriteLine($"(-) IR ({taxa_IR}): R$: {valor_taxa_IR:F2}");
            }
            else if (salario_bruto > 1500 && salario_bruto <= 2500)
            {
                taxa_IR = "10%";
                valor_taxa_IR = (salario_bruto * 0.1);
                System.Console.WriteLine($"(-) IR ({taxa_IR}): R$: {valor_taxa_IR:F2}");
            }
            else if (salario_bruto > 2500)
            {
                taxa_IR = "20%";
                valor_taxa_IR = (salario_bruto * 0.2);
                System.Console.WriteLine($"(-) IR ({taxa_IR}): R$: {valor_taxa_IR:F2}");
            }
        }

        static void Valor_hora()
        {
            double valor_hora;
            bool valor_hora_possible;

            System.Console.WriteLine("Qual o valor da sua hora de trabalho?");
            valor_hora_possible = double.TryParse(Console.ReadLine(), out valor_hora);

            if (!valor_hora_possible || valor_hora <= 0)
            {
                Valor_hora();
            }
            else
            {
                Horas_mes(valor_hora);
            }
        }

        static void Horas_mes(double valor_hora)
        {
            double horas_mes;
            bool horas_mes_possible;

            System.Console.WriteLine("Qual a quantidade de horas trabalhadas no mês?");
            horas_mes_possible = double.TryParse(Console.ReadLine(), out horas_mes);

            if (!horas_mes_possible || horas_mes <= 0)
            {
                Horas_mes(valor_hora);
            }
            else
            {
                RegraNegocio(valor_hora, horas_mes);
            }

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
                    case 1: coletaInformacoes(); break;
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
