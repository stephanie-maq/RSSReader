using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DataAccessLayer.Repositories;

namespace BuisnessLayer
{
    public class EpisodeController
    {
        IEpisodeRepository<Episode> episodeRepository;

        public EpisodeController()
        {
            episodeRepository = new EpisodeRepository();
        }

        public List<Episode> GetEpisodesByUrl(string url)
        {
            return episodeRepository.GetEpisodesFromRSS(url);
        }

        public List<Episode> GetEpisodesFromTitle(string podTitle)
        {
            return episodeRepository.GetEpisodesByTitle(podTitle);
        }
    }
}
