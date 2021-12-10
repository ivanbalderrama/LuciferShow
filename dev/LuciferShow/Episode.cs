using System;
namespace LuciferShow
{
    public class Episode
    {
        private string _title;
        private int _episodeNum;
        private int _imdbID;

        public string Title { get { return _title; } }
        public int ID { get { return _imdbID; } }

        public Episode(string title, int episodeNum, int id)
        {
            _title = title;
            _episodeNum = episodeNum;
            _imdbID = id;
        }

        public void DisplayInfo(string ID)
        {
            Console.Clear();
            UI.Header(_title);

        }
    }
}
