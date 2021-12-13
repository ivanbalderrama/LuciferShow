using System;
namespace LuciferShow
{
    public class Show
    {
        //Fields
        private string _title;
        private string _genre;
        private string _about;
        private double _rating;


        //Properties
        public string Title { get { return _title; } }
        public string Genre { get { return _genre; } }
        public string About { get { return _about; } }
        public double Rating { get { return _rating; } }

        public Show(string title, string genre, string about, double rating)
        {
            //Assign variables passed in to fields
            _title = title;
            _genre = genre;
            _about = about;
            _rating = rating;
        }

    }
}
