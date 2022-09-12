


using System;

namespace WarriorWars.ColorFullMessage
{

    static class Tools
    {
    
        public static void ColorfullMessage(char message, ConsoleColor color)
        {
            //Console.SetCursorPosition(25, 0);
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        
        }

        public static void ColorfullMessage(string message, ConsoleColor color)
        {
            //Console.SetCursorPosition(25, 0);
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        }

    }

}