using System;
using System.Xml;
using System.ServiceModel.Syndication;
namespace DataAccessLayer
{
    public class RSSReader
    {
        static void PiffPaff(string link)
        {
            XmlReader reader = XmlReader.Create(link);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            Console.WriteLine("--- Title: " + feed.Title.Text);
            Console.WriteLine("--- Description: " + feed.Description.Text);

        }
    }
}
