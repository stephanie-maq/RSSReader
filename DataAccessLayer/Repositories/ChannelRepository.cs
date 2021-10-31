using Models;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Linq;


namespace DataAccessLayer.Repositories
{
    public class ChannelRepository : IChannelRepository<Channel>
    {
        SerializerForXml<Channel> dataManager;
        List<Channel> listOfChannels;
        public ChannelRepository()
        {
            dataManager = new SerializerForXml<Channel>();
            listOfChannels = new List<Channel>();
            listOfChannels = GetAll();
        }

        public void Create(Channel entity)
        {
            listOfChannels.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            listOfChannels.RemoveAt(index);
            SaveChanges();
        }

        public List<Channel> GetAll()
        {
            List<Channel> listOfChannelsDeserialized = new List<Channel>();
            try
            {
                listOfChannelsDeserialized = dataManager.DeserializeChannel();
            }
            catch (Exception e1)
            {
                throw new Exception(e1.Message);

            }

            return listOfChannelsDeserialized;
        }



        public void SaveChanges()
        {
            dataManager.Serialize(listOfChannels);
        }

        public void Update(int index, Channel entity)
        {
            if (index >= 0)
            {
                listOfChannels[index] = entity;
            }
            SaveChanges();
        }


        public Channel GetByName(string name)
        {
            return GetAll().FirstOrDefault(p => p.Name.Equals(name));
        }

        public Channel GetByUrl(string url)
        {
            return GetAll().FirstOrDefault(p => p.RSSUrl.Equals(url));
        }

        public int GetIndex(string name)
        {
            return GetAll().FindIndex(e => e.Name.Equals(name));
        }

        //public Channel FetchFromUrl(string url)
        //{
        //    XmlReader reader = XmlReader.Create(url);
        //    SyndicationFeed feed = SyndicationFeed.Load(reader);

        //    List<Episode> episodes = new List<Episode>();

        //    feed
        //        .Items
        //        .ToList()
        //        .ForEach(item => episodes.Add(new Episode(item.Title.Text, item.Summary.Text)));

        //    Podcast podcast = new Podcast(url, feed.Title.Text, episodes);

        //    return podcast;
        //}
    }
}
