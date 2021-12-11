using System;
using System.Collections.Generic;
namespace LuciferShow
{
    public class Menu
    {
        private List<Season> _seasons = new List<Season>();
        private List<Episode> _episodes = new List<Episode>();


        public void SeasInIt(List<Season> menuOpt)
        {
            foreach (Season option in menuOpt)
            {
                _seasons.Add(option);
            }
        }

        public void EpiInIt(List<Episode> menuOpt)
        {
            foreach (Episode e in menuOpt)
            {
                _episodes.Add(e);
            }
        }

        public void EpiDisplay()
        {
            //Display episodes
            for(int i=0; i < _episodes.Count; i++)
            {
                Console.WriteLine($"{_episodes[i+1].Title}");
            }

            //Space

            //Show the exit button as 0
            Console.WriteLine("(0) Return to seasons.");
            UI.Seperator();
        }

        public void SeasonDisplay()
        {
            for (int i = 0; i < _seasons.Count; i++)
            {
                Console.WriteLine($"({i + 1}) {_seasons[i].Title}{_seasons[i].SeasonNumber}");
            }

            //Space
            Console.WriteLine();

            //Show the exit button as 0
            Console.WriteLine("(0) Exit");
            UI.Seperator();
        }

        
    }
}
