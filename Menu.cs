using System;

namespace HTMLEditor
{
    public static class Menu
    {
        public static void Show(int columns, int lines)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            
            DrawScreen(columns, lines);
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


    }
}