using System;
namespace LuciferShow
{

    //This class is used only to make the console more organized
    public class UI
    {
        public static void Header(string title)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("================================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{title.ToUpper()}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("================================================\r\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Seperator()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n-----------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void EqualSeperator()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n==========================================");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Footer()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static void FooterExit()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
