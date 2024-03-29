﻿using System;
using DataAccessLayer.Repositories;
using Models;
using System.Collections.Generic;

namespace BuisnessLayer
{
    public class Controller
    {
        IChannelRepository<Channel> channelRepository;
        EpisodeRepository episodeRepository;


        public Controller()
        {
            channelRepository = new ChannelRepository();
            episodeRepository = new EpisodeRepository();

        }

        //public Podcast FetchPodcast(string url, string category, string updateFrequency)
        //{
        //    Podcast podcast = (Podcast)channelRepository.FetchFromUrl(url);

        //    int freq = 0;

        //    switch (updateFrequency)
        //    {
        //        case "10 sekunder":
        //            freq = 10;
        //            break;
        //        case "30 sekunder":
        //            freq = 30;
        //            break;
        //        case "1 minut":
        //            freq = 60;
        //            break;
        //    }

        //    // TODO:
        //    //podcast.UpdateFrequency = from param
        //    podcast.Category = category;

        //    return podcast;
        //}


        public void DeleteChannel(string name)
        {
            int index = channelRepository.GetIndex(name);
            channelRepository.Delete(index);
        }

        public void CreateChannel(string url, string name, string category, string interval)
        {

            List<Episode> episodes = episodeRepository.GetEpisodesFromRSS(url);


            Channel newPodcast = null;

            newPodcast = new Podcast(url, name, category, episodes, interval);

            channelRepository.Create(newPodcast);
        }

        public List<Channel> GetAllPodcasts()
        {
            return channelRepository.GetAll();
        }


        public void DeletePerson(string name)
        {
            int index = channelRepository.GetIndex(name);
            channelRepository.Delete(index);
        }

        public List<Channel> GetPodcasts()
        {
            return channelRepository.GetAll();
        }

        public Channel GetPodcastByName(string name)
        {
            return channelRepository.GetByName(name);
        }

    }
}
