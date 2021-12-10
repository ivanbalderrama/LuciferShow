using System;
namespace LuciferShow
{
    public class Validation
    {
        public static int MenuValidation(string input)
        {
            int userInput;
            while(!int.TryParse(input, out userInput) || string.IsNullOrWhiteSpace(input) || userInput < 0 || userInput > 6)
            {
                Console.WriteLine("That is an invalid option.");
                Console.WriteLine("Using numbers 1-6 please select which season you'd like to learn more about.\r\n");
                input = Console.ReadLine();
            }
            return userInput;
        }
    }
}
