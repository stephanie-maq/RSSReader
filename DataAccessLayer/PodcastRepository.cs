using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using Models;

namespace DataAccessLayer
{
    public class PodcastRepository : IRemoteRepository<Podcast>
    {
        // A collection that is thread-safe for multiple thread workflows. Mostly like a list.
        private SynchronizedCollection<Podcast> podcasts;

        public PodcastRepository()
        {
            podcasts = new SynchronizedCollection<Podcast>();
        }

        public void Create(Podcast podcast)
        {
            podcasts.Add(podcast);
        }

        public void Delete(int index)
        {
            podcasts.RemoveAt(index);
        }

        public List<Podcast> GetAll()
        {
            return podcasts.ToList();
        }


        public int GetIndex(Podcast pod2)
        {
            return podcasts.ToList().FindIndex(podcast => podcast.Title.Equals(pod2.Title) && podcast.Category.Name.Equals(pod2.Category.Name));
        }

        public void Save(string path)
        {
            string json = JsonSerializer.Serialize(podcasts);
            File.WriteAllText(path, json);
        }

        public async Task<Podcast> FetchRemoteData(string url)
        {
            XmlReader reader = XmlReader.Create(url);

            SyndicationFeed feed = await Task.Run(() => SyndicationFeed.Load(reader));

            List<Episode> episodes = new List<Episode>();

            feed
                .Items
                .ToList()
                .ForEach(item => episodes.Add(new Episode(item.Title.Text, item.Summary.Text)));

            Podcast podcast = new Podcast(feed.Title.Text, episodes);

            return podcast;
        }

        public void Load(string path)
        {
            string json = File.ReadAllText(path);
            List<Podcast> pods = JsonSerializer.Deserialize<List<Podcast>>(json);
            SynchronizedCollection<Podcast> temp = new SynchronizedCollection<Podcast>();
            pods.ForEach(pod => temp.Add(pod));
            podcasts = temp;
        }

        SynchronizedCollection<Podcast> IRemoteRepository<Podcast>.GetAll()
        {
            return podcasts;
        }

        public void SetAll(List<Podcast> l)
        {
            var temp = new SynchronizedCollection<Podcast>();
            l.ForEach(elem => temp.Add(elem));
            podcasts = temp;
        }
    }
}
