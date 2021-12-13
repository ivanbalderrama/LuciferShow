using System;
using System.Collections.Generic;
namespace LuciferShow
{
    public class Menu
    {
        private List<Episode> _episodes = new List<Episode>();



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
                Console.WriteLine($"({i + 1}) {_episodes[i].Title}");
            }

            //Space

            //Show the exit button as 0
            Console.WriteLine("(0) Return to seasons.");
            UI.Seperator();
        }


        
    }
}
