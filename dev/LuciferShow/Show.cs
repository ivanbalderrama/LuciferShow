using System;
namespace LuciferShow
{
    public class Show
    {
        private string _title;
        private string _genre;
        private string _about;
        private double _rating;

        public string Title { get { return _title; } }
        public string Genre { get { return _genre; } }
        public string About { get { return _about; } }
        public double Rating { get { return _rating; } }

        public Show(string title, string genre, string about, double rating)
        {
            _title = title;
            _genre = genre;
            _about = about;
            _rating = rating;
        }
    }
}
