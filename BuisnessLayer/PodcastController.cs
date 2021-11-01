using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using Models;

namespace BuisnessLayer
{
    public class PodcastController
    {
        private IRemoteRepository<Podcast> repo;

        public PodcastController()
        {
            repo = new PodcastRepository();
        }

        private int FreqStringToInt(string updateFrequency)
        {
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

            return freq;
        }

        private void Foo(int intervall)
        {
            //TODO:
            int ms = intervall * 100;
            Task.Delay(ms);

        }

        public void KeepPodcastsUpToDate()
        {
            while (true)
            {
                var podcasts = repo.GetAll();
                podcasts.ForEach(podcast =>
                {
                    int freq = podcast.UpdateFrequency;


                });
            }
        }

        public async Task FetchPodcastAsync(string url, string category, string updateFrequency)
        {
            Podcast podcast = await repo.FetchRemoteData(url);

            int freq = FreqStringToInt(updateFrequency);

            podcast.Url = url;
            podcast.UpdateFrequency = freq;
            podcast.Category = new Category(category);

            repo.Create(podcast);
        }

        public List<Podcast> GetAllPodcasts()
        {
            return repo.GetAll();
        }
        public Tuple<bool, Podcast> GetPodcastByTitle(string title)
        {
            bool exits = repo.GetAll().Exists(podcast => podcast.Title.Equals(title));
            Podcast pod = repo.GetAll().Find(podcast => podcast.Title.Equals(title));
            return Tuple.Create(exits, pod);
        }

        public string GetEpisodeDescriptionByTitle(string title)
        {
            bool exits = repo.GetAll().Exists(podcast => podcast.Episodes.Exists(episode => episode.Title.Equals(title)));
            Episode ep = repo.GetAll().Select(podcast => podcast.Episodes.Find(episode => episode.Title.Equals(title))).First();

            if (exits)
            {
                return ep.Description;
            }

            return "";
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

        public void UpdatePodcastIntervalFrequency(string url, string newUpdateFrequency)
        {
            foreach (var podcast in repo.GetAll())
            {
                if (podcast.Url.Equals(url))
                {
                    podcast.UpdateFrequency = FreqStringToInt(newUpdateFrequency);
                }
            }
        }

        public void UpdatePodcastCategory(string url, string newCategory)
        {
            foreach (var podcast in repo.GetAll())
            {
                if (podcast.Url.Equals(url))
                {
                    podcast.Category = new Category(newCategory);
                }
            }
        }

        public void DeletePodcast(string url)
        {
            int toBeRemoved = repo.GetAll().FindIndex(podcast => podcast.Url.Equals(url));
            repo.Delete(toBeRemoved);
        }

        public void UpdateCategoryTitle(string oldTitle, string newTitle)
        {
            repo.GetAll().ForEach(podcast =>
            {
                if (podcast.Category.Name.Equals(oldTitle))
                {
                    podcast.Category = new Category(newTitle);
                }
            });
        }

        public void RemovePodcastsByCategory(string category)
        {
            List<int> toDelete = new List<int>();

            repo.GetAll().ForEach(podcast =>
            {
                if (podcast.Category.Name.Equals(category))
                {
                    int index = repo.GetIndex(podcast);
                    toDelete.Add(index);
                }
            });

            toDelete.ForEach(index => repo.Delete(index));
        }

        public List<Podcast> GetPodcastsbyCategory(string category)
        {
            return repo.GetAll().Where(podcast => podcast.Category.Name.Equals(category)).ToList();
        }
    }
}
