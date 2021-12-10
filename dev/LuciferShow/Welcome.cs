using System;
using Newtonsoft.Json.Linq;
using System.Net;
namespace LuciferShow
{
    public class Welcome
    {
        public Welcome()
        {
            //Function to display the welcome screen w/ summary about the show
            Display();
            //Instantiate the application
            Application app = new Application();
        }

        private void Display()
        {
            //Design lucifer header
            UI.Header("Lucifer");

            //Instantiate new api 
            APIConnect apiMain = new APIConnect();

            //String variable to store API url
            string urlHome = "https://omdbapi.com/?i=tt4052886&apikey=5c08013f";

            //Store info into jo
            dynamic jo = apiMain.Connect(urlHome);

            //lucifer equals to returned object from apiMain Welcome method.
            Show lucifer = apiMain.Welcome(jo);

            Console.WriteLine($"Title: {lucifer.Title}\r\n");
            Console.WriteLine($"Genre: {lucifer.Genre}\r\n");
            Console.WriteLine($"Rating: {lucifer.Rating}\r\n");
            Console.WriteLine($"About: {lucifer.About}");

            //Interface purposes
            UI.Footer();
            
        }
    }
}
