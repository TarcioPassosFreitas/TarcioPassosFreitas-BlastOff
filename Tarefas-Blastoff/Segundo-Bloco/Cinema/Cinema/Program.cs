using Cinema.Entities;
using System;

namespace Cinema 
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
            System.Console.WriteLine("Bem-vindo ao Cinema Plus Ultra"); //Bem-vindo ao Discover Game!
            System.Console.WriteLine("1 - Compra de Ingressos");
            System.Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible || option < 0 || option > 1)
            {
                Console.Clear();
                System.Console.WriteLine("Enter the value in the indicated range"); //Insira o valor no intervalo indicado
                Thread.Sleep(2500);
                Menu();
            }
            else
            {
                switch (option)
                {
                    case 1: MenuSecundario(); break;
                    case 0:
                        {
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            System.Console.WriteLine("Enter the value in the indicated range"); //Insira o valor no intervalo indicado
                            Thread.Sleep(2500);
                            Menu();
                            break;
                        }
                }
            }
        }

        static void MenuSecundario()
        {
            Console.Clear();
            short option = 0;
            bool optionPossible;

            Console.Clear();
            Console.WriteLine("Qual tipo de ingresso deseja comprar?\n");
            Console.WriteLine("1 - Ingresso Normal\n2 - Ingresso Vip\n3 - Camarote Inferior\n4 - Camarote Superior\n5 - ADM\n6 - Voltar ao Menu");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible || option < 1 || option > 6)
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
                    case 1:
                        {
                            Console.Clear();
                            IngressoNormal In = new IngressoNormal();
                            In.ImprimeValor();
                            In.ImprimeIngressoNormal();
                            Thread.Sleep(2500);
                            Console.WriteLine("Dê enter para voltar ao menu!");
                            Console.ReadLine();
                            Menu();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            IngressoVip Iv = new IngressoVip();
                            Iv.ImprimeValor();
                            Iv.ImprimeIngressoVip();
                            Thread.Sleep(2500);
                            Console.WriteLine("Dê enter para voltar ao menu!");
                            Console.ReadLine();
                            Menu();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            List<string> list = new List<string>();
                            

                            CadeirasDisponiveis(list);
                            VisualizarCadeirasDisponíveis(list);
                            Thread.Sleep(2500);
                            Console.WriteLine("\nQual cadeira vc deseja ocupar?");
                            string Cadeira = Console.ReadLine();
                            CadeirasOcupadas(Cadeira, list);

                            CamaroteInferior Ci = new CamaroteInferior(Cadeira);

                            Ci.ImprimeIngressoCamaroteInferior();

                            Thread.Sleep(2500);
                            Console.WriteLine("Dê enter para voltar ao menu!");
                            Console.ReadLine();

                            Menu();

                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            List<string> list = new List<string>();
                            

                            CadeirasDisponiveis(list);
                            VisualizarCadeirasDisponíveis(list);
                            Thread.Sleep(2500);
                            Console.WriteLine("\nQual cadeira vc deseja ocupar?");
                            string Cadeira = Console.ReadLine();
                            CadeirasOcupadas(Cadeira, list);

                            CamaroteSuperior Cs = new CamaroteSuperior(Cadeira);

                            Cs.ImprimeIngressoCamaroteSuperior();

                            Thread.Sleep(2500);
                            Console.WriteLine("Dê enter para voltar ao menu!");
                            Console.ReadLine();

                            Menu();

                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            AutenticarAdm Ad = new AutenticarAdm();
                            Ad.EntradaDeDados();

                            Thread.Sleep(2500);
                            Console.WriteLine("Dê enter para voltar ao menu!");
                            Console.ReadLine();

                            Menu();

                            break;

                        }
                    case 6:
                        {
                            Menu();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            System.Console.WriteLine("Não acredito que veio parar aqui"); //Insira o valor no intervalo indicado
                            Thread.Sleep(2500);
                            Menu();
                            break;
                        }
                }
            }
        }

        static void CadeirasDisponiveis(List<string> list)
        {
            string[] letras = new string[6] { "A", "B", "C", "D", "E", "F" };
            for(int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    list.Add(letras[i] + (j));
                }
            }
            
        }

        static void VisualizarCadeirasDisponíveis(List<string> list)
        {
            int contador = 1;
            foreach(var lists in list)
            {
                Console.Write(lists + "   ");
                if(contador == 6)
                {
                    Console.WriteLine("\n");
                    contador = 0;
                }
                contador++;
            }
        }

        static void CadeirasOcupadas(string cadeira , List<string> list)
        {
            //var pesquisa = from aux in list
            //               where aux == cadeira
            //               select aux;
            if (!list.Remove(cadeira))
            {
                Console.WriteLine("Essa cadeira não existe");
                System.Console.WriteLine("Enter the value in the indicated range"); //Insira o valor no intervalo indicado
                Thread.Sleep(1000);
                MenuSecundario();


            }

        }
    }
}
