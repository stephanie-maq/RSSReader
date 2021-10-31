using System;
using System.Collections.Generic;

namespace Models
{
    public abstract class Channel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public int UpdateFrequency { get; set; }
        public string Category { get; set; }
        public bool IsSaved { get; set; }
        protected List<Item> Items { get; set; }
    }
}
