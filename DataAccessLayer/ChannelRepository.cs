using Models;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Linq;


namespace DataAccessLayer
{
    public class ChannelRepository : IRepository<Channel>
    {
        public Channel FetchFromUrl(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            List<Episode> episodes = new List<Episode>();

            feed
                .Items
                .ToList()
                .ForEach(item => episodes.Add(new Episode(item.Title.Text, item.Summary.Text)));

            Podcast podcast = new Podcast(feed.Title.Text, episodes);

            return podcast;
        }
    }
}
