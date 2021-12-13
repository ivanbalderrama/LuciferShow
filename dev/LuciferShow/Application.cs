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

            //Main URL for the show
            string urlHome = "https://omdbapi.com/?i=tt4052886&apikey=5c08013f";

            //Return json object from main page
            dynamic jo = api.Connect(urlHome);

            //put the total seasons into a string format to be converted to an int
            string convertMe = jo.totalSeasons;
            //Convert 'convertMe' into an integer to use to display seasons menu
            int numOfSeasons = Int32.Parse(convertMe);

            bool menuGo = true;
            //continue menu till user decides to exit
            while(menuGo)
            {
                //Display the menu
                DisplayMenu(numOfSeasons);

                //Interface purposes
                UI.Seperator();

                //Request for users selection
                Console.Write("Please select which season you would like more info on: ");
                //Ask user for response (Validation)
                int seasonSelection = Validation.MenuValidation(Console.ReadLine(), _seasons);

                //Bool changes depending on menu choice of user
                menuGo = UserSelection(seasonSelection);


                _episodes = api.GetEpisodes(seasonSelection);

                Menu epiMenu = new Menu();


                epiMenu.EpiInIt(_episodes);
                epiMenu.EpiDisplay();

                //Get users input on which episode they want info from
                string episodeMess = "Please select the episode you'd like to see information on: ";
                Console.Write(episodeMess);
                int userEpis = Validation.EpisodeMenuOpt(Console.ReadLine(), episodeMess, _episodes);

                if(userEpis != 0)
                {
                    UI.Header(_episodes[userEpis - 1].Title);
                    Console.WriteLine($"{_episodes[userEpis - 1].Title}");
                    Console.WriteLine($"{_episodes[userEpis-1].EpisodeNum}");
                    UI.Footer();
                }



            }


        }

        
        private void DisplayMenu(int numOfSeasons)
        {
            Console.Clear();
            //Show header lucifer
            UI.Header("Lucifer");
            //Instantiate menu
            Menu menu = new Menu();

            //Send in the season menu items
            for (int i = 0; i < numOfSeasons; i++)
            {
                Console.WriteLine($"{i + 1}) Season: {i + 1}");
            }

            //Display the season items



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
                //Display the user header to be based on users selection
                UI.Header($"Season: {userInput}");

                
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
