using System;
using System.Collections.Generic;

namespace Models
{
    public class Podcast : Channel
    {
        public TimeSpan UpdateFrequency;
        public string Category;
        public bool IsSaved;
        public int NumberOfEpisodes;
        public List<Episode> Episodes;
        private string text;

        public Podcast(string text)
        {
            this.text = text;
        }
    }
}
