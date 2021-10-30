using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DataAccessLayer.Repositories
{
    public interface IEpisodeRepository<T> : IRepository<T> where T : Episode
    {
        //   List<T> GetEpisodesFromPodcastTitle(string podcast);

        List<T> GetEpisodesFromRSS(string url);

        List<T> GetEpisodesByTitle(string podcast);
    }
}