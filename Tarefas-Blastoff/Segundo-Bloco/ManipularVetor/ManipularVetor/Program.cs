using ManipularVetor.Entities;
using System;
using System.Text.RegularExpressions;

namespace ManipularVetor
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

            int multipliqueVetor = 0;
            bool multipliquePossible;

            Console.Clear();
            System.Console.WriteLine("Manipulando vetor");
            System.Console.WriteLine("1 - Solução vetores");
            Console.WriteLine("2 - Solução Matrizes");
            Console.WriteLine("3 - Solução Pessoas");
            System.Console.WriteLine("0 - Exit");

            optionPossible = short.TryParse(Console.ReadLine(), out option);
            if (!optionPossible || option < 0 || option > 3)
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
                            VetorManipulavel vm = new VetorManipulavel();
                            Console.WriteLine("Gerando valores aleatórios\n");
                            vm.GerarVetorAleatorio();
                            Console.WriteLine("Printando valores\n");
                            vm.PrintValoresVetor();
                            Console.WriteLine("Parte inteira do float\n");
                            vm.TruncarValores();
                            do
                            {
                                Console.WriteLine("Digite um valor para multiplicar por cada setor do vetor\n");
                                multipliquePossible = int.TryParse(Console.ReadLine(), out multipliqueVetor);
                            } while (!multipliquePossible);
                            Console.WriteLine("Vetor sendo multiplicado\n");
                            vm.MultipliqueVetor(multipliqueVetor);
                            Console.WriteLine("Printando valores atualizados\n");
                            vm.PrintValoresVetor();

                            Thread.Sleep(1000);
                            Console.WriteLine("Digite enter para voltar ao Menu\n");
                            Console.ReadLine();
                            Menu();

                            break;
                        }
                    case 2:
                        {
                            MatrizManipulavel mm = new MatrizManipulavel();
                            Console.WriteLine("Gerar valores aleatórios de uma matriz\n");
                            mm.GerarMatrizAleatoria();
                            Console.WriteLine("\n");
                            mm.SomarNumerosMatriz();
                            Console.WriteLine("\n");
                            mm.MenorEMaiorValor();
                            Console.WriteLine("\n");
                            mm.MediaValoresMatriz();

                            Thread.Sleep(1000);
                            Console.WriteLine("Digite enter para voltar ao Menu");
                            Console.ReadLine();
                            Menu();

                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            string regra = @"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$";
                            Regex regex = new Regex(regra);

                            string mensagem;
                            string endereco;
                            string telefone;
                            int idade;
                            double altura;
                            bool possivel;

                            Console.WriteLine("Digite o nome da pessoa");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Digite o seu endereço");
                            endereco = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Digite o telefone no formato (xx) xxxxx-xxxx");
                                telefone = Console.ReadLine();
                            } while (!regex.IsMatch(telefone));

                            do
                            {
                                Console.WriteLine("Digite o valor da sua idade");
                                possivel = int.TryParse(Console.ReadLine(), out idade);
                            }while (!possivel || idade < 1 || idade > 120);

                            do
                            {
                                Console.WriteLine("Digite o valor da sua altura");
                                possivel = double.TryParse(Console.ReadLine(), out altura);
                            } while (!possivel || altura > 2.8 || altura < 1.10);

                            
                            Console.WriteLine("Digite uma mensagem para aparecer no display ");
                            mensagem = Console.ReadLine();
                            
                            

                            Pessoa p = new Pessoa(nome, endereco, telefone, idade, altura);
                            Console.Clear();
                            p.ImprimirMensagem(mensagem);

                            Thread.Sleep(1000);
                            Console.WriteLine("Digite enter para voltar ao Menu\n");
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
                            System.Console.WriteLine("Insira o valor no intervalo indicado\n");
                            Thread.Sleep(2500);
                            Menu();
                            break;
                        }
                }
            }
        }
    }
}
