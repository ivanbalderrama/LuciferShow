using System;
using System.Collections.Generic;
namespace LuciferShow
{
    public class Validation
    {
        public static int MenuValidation(string input, List<Season> seasons)
        {
            int userInput;
            while(!int.TryParse(input, out userInput) || string.IsNullOrWhiteSpace(input) || userInput < 0 || userInput > 6)
            {
                Console.WriteLine("That is an invalid option.");
                Console.Write("Please select which season you would like more info on: ");
                input = Console.ReadLine();
            }
            return userInput;
        }
    }
}
