using System;
using System.Collections.Generic;
namespace LuciferShow
{
    public class Season
    {
        //Fields
        private int _seasonNum;
        private string _title;
        private List<Episode> _episodes = new List<Episode>();

        //Properties
        public int SeasonNumber { get { return _seasonNum; } }
        public string Title { get { return _title; } }


        public Season(string title, int seasonNum)
        {
            //Pass in properties
            _seasonNum = seasonNum;
            _title = title;
        }

    }
}
