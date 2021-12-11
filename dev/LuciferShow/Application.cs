using System;
using System.Collections.Generic;
namespace LuciferShow
{
    public class Application
    {
        private List<Season> _seasons = new List<Season>();
        private List<Episode> _episodes = new List<Episode>();
        public Application()
        {
            //instantiate api
            APIConnect api = new APIConnect();

            //Load seasons into list _seasons
            _seasons = api.GetSeasons();

            
            bool menuGo = true;
            //continue menu till user decides to exit
            while(menuGo)
            {
                //Display the menu
                DisplayMenu();


                Console.Write("Please select which season you would like more info on: ");
                //Ask user for response
                int seasonSelection = Validation.MenuValidation(Console.ReadLine(), _seasons);

                //Bool changes depending on menu choice of user
                menuGo = UserSelection(seasonSelection);


                _episodes = api.GetEpisodes(seasonSelection - 1);

                

            }


        }

        
        private void DisplayMenu()
        {
            Console.Clear();
            //Show header lucifer
            UI.Header("Lucifer");
            //Instantiate menu
            Menu menu = new Menu();

            //Send in the season menu items
            menu.SeasInIt(_seasons);

            //Display the season items
            menu.SeasonDisplay();



        }

        private void DisplayEpisodes()
        {
            //Clear Console
            Console.Clear();

            //Show header as "EPISODES"
            UI.Header("Episodes");

            //Instantiate a new menu for episodes
            Menu epiMenu = new Menu();

            //Send in the episode menu items
            epiMenu.EpiInIt(_episodes);

            //Display the season items
            epiMenu.EpiDisplay();


        }
        private bool UserSelection(int userInput)
        {
            UI.Seperator();

            bool menuGo = true;

            if(userInput == 0)
            {
                menuGo = false;
                Exit();
                
            }
            else
            {
                UI.Header($"{_seasons[userInput - 1].Title}{_seasons[userInput - 1].SeasonNumber}");
            }
            return menuGo;
            
        }
        private void Exit()
        {
            //Clear console
            Console.Clear();

            //Display the header to say "Exit"
            UI.Header("EXIT");

            //thank the user
            Console.WriteLine("Thank you for using the program!");

            //Display the footer
            UI.FooterExit();

        }
    }
}
