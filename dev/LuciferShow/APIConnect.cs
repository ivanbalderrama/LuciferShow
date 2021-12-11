using System;
using Newtonsoft.Json.Linq;
//Gives access to webclient
using System.Net;
using System.Collections.Generic;
namespace LuciferShow
{
    public class APIConnect
    {
        private string[] _seasUrls = new string[]
        {
            //S1
            "http://www.omdbapi.com/?i=tt4052886&Season=1&apikey=5c08013f",
            //S2
            "http://www.omdbapi.com/?i=tt4052886&Season=2&apikey=5c08013f",
            //S3
            "http://www.omdbapi.com/?i=tt4052886&Season=3&apikey=5c08013f",
            //S4
            "http://www.omdbapi.com/?i=tt4052886&Season=4&apikey=5c08013f",
            //S5
            "http://www.omdbapi.com/?i=tt4052886&Season=5&apikey=5c08013f"
        };

        public APIConnect()
        {
        }

        public dynamic Connect(string url)
        {
            using (WebClient wc = new WebClient())
            {
                //downloads the results from the url
                string results = wc.DownloadString(url);

                //Parse results into a Json object and puts it into jo
                dynamic jo = JObject.Parse(results);

                return jo;
            }
        }

        //Method that has jo passed in and assigns variable to the show class.
        public Show Welcome(dynamic jo)
        {
            //get title from jo
            string title = jo.Title;
            //get genre from jo
            string genre = jo.Genre;
            //get about from jo
            string about = jo.Plot;
            //get rating from jo
            double rating = jo.imdbRating;

            //Instantiate show lucifer passing in stored variables
            Show lucifer = new Show(title, genre, about, rating);

            //return the show
            return lucifer;
        }
        //Function that takes in json object and returns total seasons
        private List<dynamic> ConnectSeasons()
        {
            //Create a list to store the objects
            List<dynamic> jos = new List<dynamic>();

            
            using (WebClient wc = new WebClient())
            {
                //Foreach URL in _seasUrls array
                foreach(string url in _seasUrls)
                {
                    //Download the string
                    string results = wc.DownloadString(url);
                    //Parse results into a Json object and puts it into a dynamic var
                    dynamic jo = JObject.Parse(results);
                    //Add it to the list of jos
                    jos.Add(jo);
                }
            }
            //Return jos
            return jos;
        }

        //Function that turns dynamic jos into a list of seasons
        public List<Season> GetSeasons()
        {
            //List of all jos
            List<dynamic> jos = ConnectSeasons();

            //store seasons
            List<Season> seasons = new List<Season>();

            foreach(dynamic jo in jos)
            {
                int seasonNum = jo.Season;

                Season season = new Season("Season: ", seasonNum);

                seasons.Add(season);

                
                
            }

            

            return seasons;
        }


        

        public List<Episode> GetEpisodes(int seasonSelected)
        {
            
            List<Episode> episodes = new List<Episode>();

            dynamic jo = ConnectSeasons();


            JArray items = (JArray)jo["Episodes"];
            int length = items.Count;

            Console.WriteLine(length);
            

            for(int i = 0; i < length; i++)
            {
                //Store variables depending on users selection of season
                string title = jo[seasonSelected].Episodes[i].Title;
                string Id = jo[seasonSelected].Episodes[i].imdbID;
                int epiNum = jo[seasonSelected].Episodes[i].Episode;

                Episode episode = new Episode(title, epiNum, Id);

                episodes.Add(episode);
            }

             return episodes;
        }


    }
}
