using PoderCompra.Entities;
using System;

namespace PoderCompra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            short option = 0;
            bool optionPossible;

            Console.Clear();
            System.Console.WriteLine("Bem-vindo à feira");
            System.Console.WriteLine("1 - Compra Normal");
            Console.WriteLine("2 - Compra Estudante");
            System.Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible || option < 0 || option > 2)
            {
                Console.Clear();
                System.Console.WriteLine("Insira o valor no intervalo indicado");
                Thread.Sleep(2500);
                Menu();
            }
            else
            {
                switch (option)
                {
                    case 1:
                        {
                            double preco;
                            int parcelas;
                            string tipo;
                            bool possivel;

                            do
                            {
                                Console.WriteLine("Digite o valor do preço do produto");
                                possivel = double.TryParse(Console.ReadLine(), out preco);
                            }while (!possivel || preco < 5);
                            do
                            {
                                Console.WriteLine("Digite em quantas parcelas planeja dividir");
                                possivel = int.TryParse(Console.ReadLine(), out parcelas);
                            }while(!possivel || parcelas < 0);

                            Console.WriteLine("Digite seu tipo");
                            tipo = Console.ReadLine();

                            Compra c = new Compra(preco, parcelas, tipo);
                            Console.WriteLine("Pagar parcela");
                            c.PagarParcela();
                            Console.WriteLine("Quitar compra");
                            c.QuitarCompra();
                            Console.WriteLine("Cancelar compra");
                            c.CancelarCompra();
                            Console.WriteLine("Atualizar parcela");
                            do
                            {
                                Console.WriteLine("Digite em quantas parcelas planeja dividir");
                                possivel = int.TryParse(Console.ReadLine(), out parcelas);
                            } while (!possivel || parcelas < 0);
                            c.atualizarParcela(parcelas, 0.3);
                            Thread.Sleep(2500);
                            Console.WriteLine("Dê enter para voltar ao Menu");
                            Console.ReadLine();
                            Menu();

                            break;
                        }
                    case 2:
                        {
                            double preco;
                            int parcelas;
                            string tipo;
                            bool possivel;

                            do
                            {
                                Console.WriteLine("Digite o valor do preço do produto");
                                possivel = double.TryParse(Console.ReadLine(), out preco);
                            } while (!possivel || preco < 5);
                            do
                            {
                                Console.WriteLine("Digite em quantas parcelas planeja dividir");
                                possivel = int.TryParse(Console.ReadLine(), out parcelas);
                            } while (!possivel || parcelas < 0);

                            Console.WriteLine("Digite seu tipo");
                            tipo = Console.ReadLine();

                            ContaEstudante ce = new ContaEstudante(preco, parcelas, tipo);
                            //Console.WriteLine("Pagar parcela");
                            //ce.PagarParcela();
                            //Console.WriteLine("Quitar compra");
                            //ce.QuitarCompra();

                            ce.Valores(new ContaEstudante(150.00, 3, "Diversão"));
                            Thread.Sleep(2500);
                            Console.WriteLine("Dê enter para voltar ao Menu");
                            Console.ReadLine();
                            Menu();

                            break;
                        }
                    case 0:
                        {
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            System.Console.WriteLine("Insira o valor no intervalo indicado");
                            Thread.Sleep(2500);
                            Menu();
                            break;
                        }
                }
            }
        }
    }
}
