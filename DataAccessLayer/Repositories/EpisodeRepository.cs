using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Syndication;
using System.Xml;


namespace DataAccessLayer.Repositories
{
    public class EpisodeRepository : IEpisodeRepository<Episode>
    {
        SerializerForXml<Episode> dataManager;
        List<Episode> listOfEpisodes;
        public EpisodeRepository()
        {
            dataManager = new SerializerForXml<Episode>();
            listOfEpisodes = new List<Episode>();
            listOfEpisodes = GetAll();
        }

        public void Create(Episode entity)
        {
            listOfEpisodes.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            listOfEpisodes.RemoveAt(index);
            SaveChanges();
        }

        public List<Episode> GetAll()
        {
            List<Episode> listOfCategoriesDeserialized = new List<Episode>();
            try
            {
                listOfCategoriesDeserialized = dataManager.Deserialize();
            }
            catch (Exception)
            {


            }

            return listOfCategoriesDeserialized;
        }



        public void SaveChanges()
        {
            dataManager.Serialize(listOfEpisodes);
        }

        public void Update(int index, Episode entity)
        {
            if (index >= 0)
            {
                listOfEpisodes[index] = entity;
            }
            SaveChanges();
        }

        //public async Task<List<Episode>> GetEpisodesFromRSS(string url)
        //{
        //    XmlReader rssReader = XmlReader.Create(url);
        //    SyndicationFeed rssFeed = await Task.Run(() => SyndicationFeed.Load(rssReader));

        //    List<Episode> episodes = new List<Episode>();
        //    foreach (SyndicationItem item in rssFeed.Items)
        //    {
        //        Episode episode = new Episode();
        //        episode.Title = item.Title.Text;
        //        episode.Description = item.Summary.Text;
        //        episodes.Add(episode);
        //    }
        //    return episodes;
        //}

        public List<Episode> GetEpisodesByTitle(string podTitle)
        {
            List<Episode> allEpisodes = new List<Episode>();

            return allEpisodes;
        }

        public List<Episode> GetEpisodesFromRSS(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            List<Episode> episodes = new List<Episode>();
            foreach (SyndicationItem item in feed.Items)
            {
                Episode episode = new Episode();
                episode.Name = item.Title.Text;
                episode.Description = item.Summary.Text;
                episodes.Add(episode);
            }
            return episodes;
        }

    }
}
