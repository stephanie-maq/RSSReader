using System;
using System.Collections.Generic;

namespace Models
{
    public class Podcast : Channel
    {
        public TimeSpan UpdateFrequency;
        public string Category;
        public bool IsSaved;
        public int NumberOfEpisodes { get; }
        public List<Episode> Episodes;

        public Podcast(string name, List<Episode> episodes)
        {
            this.name = name;
            Episodes = episodes;
            NumberOfEpisodes = episodes.Count;
        }
    }
}