using System.IO;
using System;

namespace CursoEditorDeTextos
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
            System.Console.WriteLine("O que você deseja fazer?");
            System.Console.WriteLine("1 - Abrir arquivo");
            System.Console.WriteLine("2 - Criar novo arquivo");
            System.Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            System.Console.WriteLine("Qual o caminho do arquivo?");
            String path = Console.ReadLine();

            using (var file = new StreamReader(path)) //Nesse caso queremos ler o arquivo, não criar, por isso StreamReader
            {
                String text = file.ReadToEnd(); //ler o arquivo até o final
                System.Console.WriteLine(text);
            }
            System.Console.WriteLine(""); //para pular uma linha
            Console.ReadLine(); //precisa dar um enter pra depois voltar para o menu
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            System.Console.WriteLine("Digite seu texto aqui (ESC) Para sair");
            System.Console.WriteLine("-----------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine; //quebrando linha
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            //System.Console.Write(text); //entende o enter como uma quebra de linha, por isso quebra uma letra
            Salvar(text);

        }

        static void Salvar(String text)
        {
            Console.Clear();
            System.Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            //Toda vez que trabalhar com arquivos, tem que abrir e fechar o arquivo
            //Abrir o arquivo: para leitura = StreamReader, para escrita = StreamWriter
            //Usa new para abrir o arquivo e close para fechar
            //A chance de abrir e esquecer de fechar, é melhor usar o using, pra abrir e fechar arquivos, banco de dados, qualquer coisa
            using (var file = new StreamWriter(path)) //ele vai abrir e fechar, melhor forma. Passa como referência o caminho do arquivo
            {
                file.Write(text); //escreva
            }

            System.Console.WriteLine($"Arquivo {path} Salvo com Sucesso!");
            System.Console.ReadLine();
            Menu();
        }
    }
}
