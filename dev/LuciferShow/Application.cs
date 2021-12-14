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
            while (menuGo)
            {
                //Display the menu
                DisplayMenu(numOfSeasons);

                //Interface purposes
                UI.Seperator();

                //Request for users selection
                Console.Write("Please select which season you would like more info on: ");
                //Ask user for response (Validation)
                int seasonSelection = Validation.MenuValidation(Console.ReadLine());
                
                //Bool changes depending on menu choice of user
                menuGo = UserSelection(seasonSelection);
                if(seasonSelection != 0)
                { 
                //Get the episodes depending on users selection and store them to the list
                _episodes = api.GetEpisodes(seasonSelection - 1);

                bool epiMenuGo = true;
                    while (epiMenuGo)
                    {
                        Console.Clear();
                        UI.Header($"Season: {seasonSelection}");
                        Menu epiMenu = new Menu();
                        //Pass in the list of episodes
                        epiMenu.EpiInIt(_episodes);
                        //Display the menu
                        epiMenu.EpiDisplay();

                        //Get users input on which episode they want info from
                        string episodeMess = "Please select the episode you'd like to see information on: ";
                        Console.Write(episodeMess);
                        //int variable to get users input to select the episode using validation.
                        int userEpis = Validation.EpisodeMenuOpt(Console.ReadLine(), episodeMess, _episodes);
                        //If the user selects anything other than '0' (Exit) then run this code.
                        if (userEpis != 0)
                        {
                            
                            //Clear the console
                            Console.Clear();
                            //Show the header depending users selection
                            UI.Header(_episodes[userEpis - 1].Title);
                            //Display the title of the episode
                            Console.WriteLine($"Episode Title: {_episodes[userEpis - 1].Title}");
                            //Display the number of the episode
                            Console.WriteLine($"Episode Number: {_episodes[userEpis - 1].EpisodeNum}");
                            //Get other information of the episode to display.
                            api.EpisodeInfo(_episodes[userEpis - 1].ID);
                            //User interface (organization purposes)
                            UI.Footer();


                        }

                        else
                        {
                            epiMenuGo = false;
                        }
                    }
                }
            }
        }

        //Method to display the menu of seasons
        private void DisplayMenu(int numOfSeasons)
        {
            //Clear the console.
            Console.Clear();
            //Show header lucifer
            UI.Header("Lucifer");
            //Instantiate menu
            Menu menu = new Menu();

            //Loop as many times as there are seasons
            for (int i = 0; i < numOfSeasons; i++)
            {
                //Display the number they can input and the season number
                Console.WriteLine($"({i + 1}) Season: {i + 1}\r\n");
            }
            //Display the exit option
            Console.WriteLine("(0) Exit");
        }

        
        /*Method is used to get the users selection and if the user chooses to
         * exit then it will return a boolean of false so that the menu stops
         * looping and the program exits
         */
        private bool UserSelection(int userInput)
        {
            //Just a seperator for organization purposes
            UI.Seperator();
            //Menu of bool = true as long as user doesn't choose to exit
            bool menuGo = true;
            //If the user selects 0 then return false and display the Exit();
            if(userInput == 0)
            {
                menuGo = false;
                Exit();
                
            }
            //Return bool
            return menuGo;
            
        }
        //This method is only used to thank the user for using the program
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
