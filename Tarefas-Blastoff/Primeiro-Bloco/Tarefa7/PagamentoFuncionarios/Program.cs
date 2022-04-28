using System;

namespace PagamentoFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bem-vindo ao sistema de salário com comissões");


            double[] array_salarios = new double[9];
            //double[] array_salarios = new double[9] { 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
            double[] array_indices = new double[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double indice;
            double indice_maximo;

            EntradaDados(array_salarios);
            System.Console.WriteLine("===================================================");
            foreach (double salario in array_salarios)
            {
                indice = ((salario / 100) - 2);

                indice_maximo = array_salarios.Length - 1;

                Limitador(indice, indice_maximo);
                array_indices[(int)indice] += 1;
            }
            System.Console.WriteLine("===============================================");

            foreach (double testando in array_indices)
            {

                System.Console.WriteLine(testando);
            }






        }

        static void Limitador(double indice, double indice_maximo)
        {
            if (indice > indice_maximo)
            {
                indice = indice_maximo;
            }

        }

        static void EntradaDados(double[] array_salarios)
        {
            double y;
            int contador = 9;
            bool x_aux;
            double x = 0;
            System.Console.WriteLine("Quantidade de vendas brutas do Mês de 9 funcionários:");
            for (int i = 0; i < contador; i++)
            {
                x_aux = double.TryParse(Console.ReadLine(), out x);
                if (!x_aux && x < 0)
                {
                    EntradaDados(array_salarios);
                }
                else
                {
                    y = 200 + (0.09 * x);
                    array_salarios[i] = y;
                }
            }

        }
    }
}
