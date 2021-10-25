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

        public Podcast FetchPodcast(string url, string category, string updateFrequency)
        {
            Podcast podcast = (Podcast)repo.FetchFromUrl(url);

            int freq = 0;

            switch (updateFrequency)
            {
                case "10 sekunder":
                    freq = 10;
                    break;
                case "30 sekunder":
                    freq = 30;
                    break;
                case "1 minut":
                    freq = 60;
                    break;
            }

            // TODO:
            //podcast.UpdateFrequency = from param
            podcast.Category = category;

            return podcast;
        }
    }
}
