using System;
using DataAccessLayer.Repositories;
using Models;
using System.Collections.Generic;

namespace BuisnessLayer
{
    public class Controller
    {
        IChannelRepository<Channel> channelRepository;

        public Controller()
        {
            channelRepository = new ChannelRepository();
        }

        public Podcast FetchPodcast(string url, string category, string updateFrequency)
        {
            Podcast podcast = (Podcast)channelRepository.FetchFromUrl(url);

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


        public void DeleteChannel(string name)
        {
            int index = ChannelRepository.GetIndex(name);
            channelRepository.Delete(index);
        }

        public void CreateChannel(string name, string pn, string address, string objectType)
        {
            Channel newChannel = null;
           
                newChannel = new Podcast(name, pn, address);
           
            channelRepository.Create(newPodcast);
        }

        public List<Channel> GetAllPersons()
        {
            return channelRepository.GetAll();
        }


        public void DeletePerson(string name)
        {
            int index = channelRepository.GetIndex(name);
            channelRepository.Delete(index);
        }

    }
}
