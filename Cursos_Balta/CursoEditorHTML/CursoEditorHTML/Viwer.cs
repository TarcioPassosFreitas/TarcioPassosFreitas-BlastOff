using System.Text.RegularExpressions;
using System;

namespace CursoEditorHTML
{
    public class Viewer
    {
        public static void Show(String text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Console.WriteLine("MODO VISUALIZAÇÃO");
            System.Console.WriteLine("-------------");
            Replace(text);
            System.Console.WriteLine("-------------");
            Console.ReadKey();
            Menu.Show();

        }

        public static void Replace(String text)
        {
            //substituir alguns caracters no nosso texto
            //utilizou o Regex
            //"text <strong>text</strong>"
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            //System.Console.WriteLine(strong);
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    //Se a expressão regex bate com a palavra que está sendo testada
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        //"<strong>Meu texto</strong>"
                        //Meu texto
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) -
                                words[i].IndexOf('>')
                            )
                        )
                    );

                    System.Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}