using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using Models;

namespace BuisnessLayer
{
    public class PodcastController
    {
        private string saveFilePath;
        private IRemoteRepository<Podcast> repo;

        public PodcastController(string path)
        {
            repo = new PodcastRepository();

            if (Validation.FileExists(path))
            {
                repo.Load(path);
            }
            else
            {
                string json = "[]";
                File.WriteAllText(path, json);
            }

            saveFilePath = path;
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

        public void LoadFromFile()
        {
            repo.Load(saveFilePath);
        }

        // Always executing method. Should be called in a separate thread.
        public async void UpdateWithIntervall(int intervall)
        {
            while (true)
            {
                int ms = intervall * 100;
                await Task.Delay(ms);

                List<Podcast> toUpdate = new List<Podcast>();

                switch (intervall)
                {
                    case 10:
                        toUpdate = repo.GetAll().Where(p => p.UpdateFrequency == 10).ToList();
                        break;
                    case 30:
                        toUpdate = repo.GetAll().Where(p => p.UpdateFrequency == 30).ToList();
                        break;
                    case 60:
                        toUpdate = repo.GetAll().Where(p => p.UpdateFrequency == 60).ToList();
                        break;
                }

                foreach (Podcast currentPodcast in toUpdate)
                {
                    Podcast newPodcast = await repo.FetchRemoteData(currentPodcast.Url);
                    currentPodcast.Episodes = newPodcast.Episodes;
                }
            }
        }

        private void AddPodcast(Podcast podcast)
        {
            bool exists = repo.GetAll().ToList().Exists(pod => pod.Url.Equals(podcast.Url));

            if (exists)
            {
                throw new CustomExceptions.ItemAlreadyExistsException("Podcasten finns redan!");
            }
            else
            {
                repo.Create(podcast);
            }
        }

        public async Task FetchPodcastAsync(string url, string category, string updateFrequency)
        {
            Podcast podcast = await repo.FetchRemoteData(url);

            podcast.Url = url;
            podcast.UpdateFrequency = FreqStringToInt(updateFrequency);
            podcast.Category = new Category(category);

            AddPodcast(podcast);
        }

        public async Task FetchPodcastAsync(string title, string url, string category, string updateFrequency)
        {
            Podcast podcast = await repo.FetchRemoteData(url);

            podcast.Title = title;
            podcast.Url = url;
            podcast.UpdateFrequency = FreqStringToInt(updateFrequency);
            podcast.Category = new Category(category);

            AddPodcast(podcast);
        }

        public ICollection<Podcast> GetAllPodcasts()
        {
            return repo.GetAll();
        }

        public Tuple<string, List<string>> GetPodcastUrlAndEpisodesByTitle(string title)
        {
            bool exits = repo.GetAll().ToList().Exists(podcast => podcast.Title.Equals(title));
            Podcast pod = repo.GetAll().ToList().Find(podcast => podcast.Title.Equals(title));

            List<string> eps = new List<string>();

            if (exits)
            {
                pod.Episodes.Reverse();
                pod.Episodes.ForEach(ep => eps.Add(ep.StringToDisplay()));
            }

            return Tuple.Create(pod.Url, eps);
        }

        public string GetEpisodeDescriptionByTitle(string title)
        {
            string temp = "";

            foreach (Podcast podcast in repo.GetAll())
            {
                foreach (Episode episode in podcast.Episodes)
                {
                    if (episode.Title.Equals(title))
                    {
                        temp = episode.Description;
                    }
                }
            }

            return temp;
        }

        public void UpdatePodcastTitle(string url, string newTitle)
        {
            foreach (Podcast podcast in repo.GetAll())
            {
                if (podcast.Url.Equals(url))
                {
                    podcast.Title = newTitle;
                }
            }
        }

        public void UpdatePodcastIntervalFrequency(string url, string newUpdateFrequency)
        {
            foreach (Podcast podcast in repo.GetAll())
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
            int toBeRemoved = repo.GetAll().ToList().FindIndex(podcast => podcast.Url.Equals(url));
            repo.Delete(toBeRemoved);
        }

        public void UpdateCategoryTitle(string oldTitle, string newTitle)
        {
            repo.GetAll().ToList().ForEach(podcast =>
            {
                if (podcast.Category.Name.Equals(oldTitle))
                {
                    podcast.Category = new Category(newTitle);
                }
            });
        }

        public void RemovePodcastsByCategory(string category)
        {
            repo.SetAll(repo.GetAll().Where(podcast => !podcast.Category.Name.Equals(category)).ToList());
        }

        public List<Podcast> GetPodcastsbyCategory(string category)
        {
            return repo.GetAll().Where(podcast => podcast.Category.Name.Equals(category)).ToList();
        }

        public void SaveAllPodcasts()
        {
            repo.GetAll().ToList().ForEach(podcast => podcast.IsSaved = true);
            repo.Save(saveFilePath);
        }

        public bool IsAllSaved()
        {
            foreach (var item in repo.GetAll())
            {
                if (!item.IsSaved)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
