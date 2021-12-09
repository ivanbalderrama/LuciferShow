﻿using System;
namespace LuciferShow
{
    public class UI
    {
        public static void WelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("================================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("LUCIFER");
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
    }
}