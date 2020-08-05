using System;

namespace HTMLEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            
            DrawScreen(40, 20);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }
        public static void DrawScreen(int columns, int lines)
        {
            DrawTopDown(columns);
            DrawLines(columns, lines);
            DrawTopDown(columns);
        }

        public static void DrawTopDown(int numberOfColumns)
        {
            Console.Write("+");
            for (int i = 0; i <= numberOfColumns; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.WriteLine();
        }

        public static void DrawLines(int numberOfColumns, int numberOfLines)
        {
            for (int lines = 0; lines <= numberOfLines; lines++)
            {
                Console.Write("|");
                for (int spaces = 0; spaces <= numberOfColumns; spaces++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.SetCursorPosition(3,5);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Console.WriteLine("Editor"); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;

            }
        }
    }
}