using System;
using Newtonsoft.Json.Linq;
//Gives access to webclient
using System.Net;
namespace LuciferShow
{
    public class APIConnect
    {
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
    }
}
