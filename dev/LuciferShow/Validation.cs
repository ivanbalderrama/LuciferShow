using System;
using System.Collections.Generic;
namespace LuciferShow
{
    public class Validation
    {
        public static int MenuValidation(string input, List<Season> seasons)
        {
            int userInput;
            while(!int.TryParse(input, out userInput) || string.IsNullOrWhiteSpace(input) || userInput <=0 || userInput > 6)
            {
                Console.WriteLine("That is an invalid option.");
                Console.Write("Please select which season you would like more info on: ");
                input = Console.ReadLine();
            }
            return userInput;
        }

        public static int EpisodeMenuOpt(string userInp, string message, List<Episode> menuOpt)
        {
            int userNum;

            while (!int.TryParse(userInp, out userNum) || string.IsNullOrWhiteSpace(userInp) || userNum < 0 || userNum > menuOpt.Count)
            {
                Console.WriteLine("That's an invalid option.");
                Console.WriteLine(message);
                userInp = Console.ReadLine();
            }

            return userNum;

        }
    }
}
