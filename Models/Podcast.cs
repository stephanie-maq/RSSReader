using System;
using System.Collections.Generic;

namespace Models
{
    public class Podcast : Channel
    {
        // public TimeSpan UpdateFrequency;
        //public Category Category;
        //public bool IsSaved;
        //public int NumberOfEpisodes { get; }
        //public List<Episode> Episodes;


        public Podcast(string rssUrl, string name, string category, List<Episode> episodes, string interval) : base(rssUrl, name, category, episodes, interval)
        {
            //RSSUrl = rssUrl;
            //Name = name;
            //Category = category;
            //Episodes = episodes;
            //Interval = interval;
            // NumberOfEpisodes = episodes.Count;
        }

        public Podcast()
        {

        }


    }
}