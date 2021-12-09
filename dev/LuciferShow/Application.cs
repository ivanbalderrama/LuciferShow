using System;
namespace LuciferShow
{
    public class Application
    {
        public Application()
        {
            //instantiate api
            APIConnect api = new APIConnect();

            //Create a string var to hold the URL.
            string url = "https://omdbapi.com/?i=tt4052886&apikey=5c08013f";

            //Call api Connect method.
            api.Connect(url);
        }
    }
}
