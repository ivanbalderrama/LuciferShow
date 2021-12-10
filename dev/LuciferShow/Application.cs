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

            _seasons = api.GetSeasons();

            foreach(Season season in _seasons)
            {
                Console.WriteLine(season.Title);
            }

            //Create a string var to hold the URL.

            //Send the url to get the api connected.
            Console.ReadLine();



            

            

        }

        
        private void DisplayMenu()
        {
            //Clear Console
            Console.Clear();
            //Show header lucifer
            UI.Header("Lucifer");


            

        }
    }
}
