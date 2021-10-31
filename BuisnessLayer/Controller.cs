using System;
using System.Threading.Tasks;
using DataAccessLayer;
using Models;

namespace BuisnessLayer
{
    public class Controller
    {
        private IRepository<Podcast> repo;

        public Controller()
        {
            repo = new PodcastRepository();
        }

        public async Task<Podcast> FetchPodcastAsync(string url, string category, string updateFrequency)
        {
            Podcast podcast = await repo.FetchRemoteData(url);

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

            podcast.UpdateFrequency = freq;
            podcast.Category = category;

            repo.Create(podcast);

            return podcast;
        }
    }
}
