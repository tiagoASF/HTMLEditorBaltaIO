using System;
using System.Text.RegularExpressions;

namespace HTMLEditor
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine();
            Replace(text);
            Console.WriteLine();
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(" ");
            foreach(string word in words)
            {
                if (strong.IsMatch(word))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        word.Substring(
                            word.IndexOf('>') + 1,
                            (
                                (word.LastIndexOf('<') - 1) - 
                                word.IndexOf('>')
                            )    
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(word);
                    Console.Write(" ");
                }
            }
        }
    }
}