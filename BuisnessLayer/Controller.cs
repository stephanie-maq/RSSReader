using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task FetchPodcastAsync(string url, string category, string updateFrequency)
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

            podcast.Url = url;
            podcast.UpdateFrequency = freq;
            podcast.Category = category;

            repo.Create(podcast);
        }

        public Tuple<bool, Podcast> GetPodcastByTitle(string title)
        {
            bool exits = repo.GetAll().Exists(podcast => podcast.Title.Equals(title));
            Podcast pod = repo.GetAll().Find(podcast => podcast.Title.Equals(title));
            return Tuple.Create(exits, pod);
        }

        public Tuple<bool, Episode> GetEpisodeByTitle(string title)
        {
            bool exits = repo.GetAll().Exists(podcast => podcast.Episodes.Exists(episode => episode.Title.Equals(title)));
            Episode ep = repo.GetAll().Select(podcast => podcast.Episodes.Find(episode => episode.Title.Equals(title))).First();
            return Tuple.Create(exits, ep);
        }

        public void UpdatePodcastTitle(string url, string newTitle)
        {
            foreach (var podcast in repo.GetAll())
            {
                if (podcast.Url.Equals(url))
                {
                    podcast.Title = newTitle;
                }
            }
        }

        public List<Podcast> GetAllPodcasts()
        {
            return repo.GetAll();
        }
    }
}
