using System;
using System.Collections.Generic;

namespace Models
{
    public class Podcast
    {
        private string name { get; set; }
        private TimeSpan updateFrequency;
        private List<string> category;
        private bool isSaved;
        private int numberOfEpisodes;
        private Uri url;
        private List<Episode> episodes;
    }
}
