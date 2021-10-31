using System;
using System.Collections.Generic;

namespace Models
{
    public class Podcast : Channel
    {
        public List<Episode> Episodes { get; set; }

        public Podcast(string title, List<Episode> episodes)
        {
            Title = title;
            Episodes = episodes;
        }
    }
}
