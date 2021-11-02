using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Models;

namespace BuisnessLayer
{
    public class Validation
    {
        public static bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public static void UrlExists(string url)
        {
            if (!url.StartsWith("https://") || url.StartsWith("http://"))
            {
                throw new CustomExceptions.UrlIsNotValid("URl är ogiltig");
            }
        }

        public static void PodcastExists(List<Podcast> podcasts, Podcast podcast)
        {
            bool exists = podcasts.Exists(p => p.Url.Equals(podcast.Url));
            if (exists)
            {
                throw new CustomExceptions.ItemAlreadyExistsException("Podcasten finns redan!");
            }

        }
    }
}
