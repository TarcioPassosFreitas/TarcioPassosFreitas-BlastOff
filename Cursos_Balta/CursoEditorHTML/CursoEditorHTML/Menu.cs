using System;

namespace CursoEditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue; //trocar a cor de fundo do console
            Console.ForegroundColor = ConsoleColor.Black; //trocar a cor da letra do console

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            //System.Console.Write("+");
            // "+--------------------------------------------------+"
            // "|                                                  |"
            // "|                                                  |"
            // "+--------------------------------------------------+"
            EstruturaDoEditor();

        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2); //mudar localização do cursor, (linha, coluna)
            System.Console.Write("Editor HTML");
            Console.SetCursorPosition(3, 3); //mudar localização do cursor, (linha, coluna)
            System.Console.Write("============");
            Console.SetCursorPosition(3, 4); //mudar localização do cursor, (linha, coluna)
            System.Console.Write("Selecione uma Opção abaixo");
            Console.SetCursorPosition(3, 6); //mudar localização do cursor, (linha, coluna)
            System.Console.Write("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7); //mudar localização do cursor, (linha, coluna)
            System.Console.Write("2 - Abrir");
            Console.SetCursorPosition(3, 9); //mudar localização do cursor, (linha, coluna)
            System.Console.Write("0 - Sair");
            Console.SetCursorPosition(3, 10); //mudar localização do cursor, (linha, coluna)
            System.Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            //Handle significa manipular
            //Criar função que manipula o clique do botão por exemplo
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: System.Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
        static void LinhaInicial()
        {
            System.Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                System.Console.Write("-");
            }
            System.Console.Write("+");
            System.Console.Write("\n");

        }

        static void LinhaIntermediaria()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                System.Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("|");
                System.Console.Write("\n");
            }
        }

        static void EstruturaDoEditor()
        {
            LinhaInicial();
            LinhaIntermediaria();
            LinhaInicial();
        }
    }
}