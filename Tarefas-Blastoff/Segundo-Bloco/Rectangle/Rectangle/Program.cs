using System;

namespace Rectangle
{
    internal class Program
    {
        private static double comprimentoPiso;

        static void Main(string[] args)
        {
            Menu();
        }

        

        static void Menu()
        {
            short option = 0;
            bool optionPossible;

            Console.Clear();
            Console.WriteLine("Sistema de ajuda metragem de pisos");
            System.Console.WriteLine("1 - Start");
            System.Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible)
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
                            Console.Clear();

                            double ComprimentoPiso;
                            double larguraPiso;
                            double comprimento;
                            double largura;
                            bool possivel;

                            do
                            {
                                Console.WriteLine("Digite o comprimento da sua residência em metros");
                                possivel = double.TryParse(Console.ReadLine(), out comprimento);
                            } while (!possivel || comprimento < 3);

                            do
                            {
                                Console.WriteLine("Digite a largura da sua residência em metros");
                                possivel = double.TryParse(Console.ReadLine(), out largura);
                            } while (!possivel || largura < 3);

                            do
                            {
                                Console.WriteLine("Digite o comprimento que vc deseja o seu piso em metros");
                                Console.WriteLine("Ex: Azulejo de 30cm = 0.3 m");
                                possivel = double.TryParse(Console.ReadLine(), out ComprimentoPiso);
                            } while (!possivel || ComprimentoPiso < 0 || ComprimentoPiso > 2);

                            do
                            {
                                Console.WriteLine("Digite a largura da sua residência em metros");
                                Console.WriteLine("Ex: Azulejo de 30cm = 0.3 m");
                                possivel = double.TryParse(Console.ReadLine(), out larguraPiso);
                            } while (!possivel || larguraPiso < 0 || larguraPiso > 2);

                            RetanguloModelo rm = new RetanguloModelo(comprimento, largura, ComprimentoPiso, larguraPiso);

                            Console.Clear();
                            
                            rm.QuantidadePisos();
                            rm.QuantidadeRodapes();

                            Thread.Sleep(1000);
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
                            Thread.Sleep(1000);
                            Menu();
                            break;
                        }
                }
            }
        }
    }
}
