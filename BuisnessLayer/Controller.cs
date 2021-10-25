using System;
using DataAccessLayer;
using Models;

namespace BuisnessLayer
{
    public class Controller
    {
        private IRepository<Channel> repo;

        public Controller()
        {
            repo = new ChannelRepository();
        }

        public Podcast FetchPodcast(string url)
        {
            Podcast podcast = (Podcast)repo.FetchFromUrl(url);

            //podcast.UpdateFrequency = from param
            // podcast.cat = from param 

            return podcast;
        }
    }
}
