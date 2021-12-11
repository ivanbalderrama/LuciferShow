using System;
namespace LuciferShow
{
    public class Episode
    {
        private string _title;
        private int _episodeNum;
        private string _imdbID;

        public string Title { get { return _title; } }
        public string ID { get { return _imdbID; } }

        public Episode(string title, int episodeNum, string id)
        {
            _title = title;
            _episodeNum = episodeNum;
            _imdbID = id;
        }

    }
}
