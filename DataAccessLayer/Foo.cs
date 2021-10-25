using Models;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Linq;


namespace DataAccessLayer
{
    public class Foo
    {
        public static Podcast LinkReader(string link, TimeSpan refresh, string category)
        {
            XmlReader reader = XmlReader.Create(link);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            List<Episode> episodes = new List<Episode>();

            feed
                .Items
                .ToList()
                .ForEach(item => episodes.Add(new Episode(item.Title.Text, item.Summary.Text)));

            Podcast podcast = new Podcast(feed.Title.Text);
            podcast.Episodes = episodes;

            return podcast;
        }
    }
}
