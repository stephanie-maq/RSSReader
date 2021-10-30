using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{
    [XmlInclude(typeof(Podcast))]
    public abstract class Channel
    {
        public string RSSUrl { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }

        public List<Episode> Episodes { get; set; }
        public string Interval { get; set; }

        public Channel(string rssUrl, string name, string category, List<Episode> episodes, string interval)
        {
            RSSUrl = rssUrl;
            Name = name;
            Category = category;
            Episodes = episodes;
            Interval = interval;
        }

        public Channel()
        {

        }

        public string getName() { return Name; }
    }
}
