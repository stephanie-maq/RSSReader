using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Models;
using System.Text;
using DataAccesLayer.Exceptions;

namespace DataAccessLayer
{
    internal class SerializerForXml<T>
    {
        public void Serialize(List<T> ChannelList)
        {
            if (ChannelList.GetType().ToString() == "System.Collections.Generic.List`1[Models.Channel]")
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    using (FileStream outFile = new FileStream("Podcasts.xml", FileMode.OpenOrCreate,
                        FileAccess.Write))
                    {
                        xmlSerializer.Serialize(outFile, ChannelList);
                    }
                }
                catch (Exception e)
                {
                    throw new SerializerException("Podcasts.xml", "Could not serialize to the file");
                }

            }
            else if (ChannelList.GetType().ToString() == "System.Collections.Generic.List`1[Models.Category]")
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    using (FileStream outFile = new FileStream("Categories.xml", FileMode.OpenOrCreate,
                        FileAccess.Write))
                    {
                        xmlSerializer.Serialize(outFile, ChannelList);
                    }
                }
                catch (Exception e)
                {
                    throw new SerializerException("Categories.xml", "Could not serialize to the file");
                }
            }

        }

        //public void SerializePodcast(List<Channel> podcasts)
        //{

        //    try
        //    {
        //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Channel>));
        //        using (FileStream Outfile = new FileStream("Podcastss.xml", FileMode.Create, FileAccess.Write))
        //        {
        //            xmlSerializer.Serialize(Outfile, podcasts);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new SerializerException("Podcasts.xml", "Could not serialize to the file");
        //    }

        //}

        public List<T> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                using (FileStream inFile = new FileStream("Podcasts.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<T>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);

            }
        }
        public List<Channel> DeserializeChannel()
        {
            try
            {
                List<Channel> channelsToBeReturned;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Channel>));
                using (FileStream inFile = new FileStream("Podcasts.xml", FileMode.Open, FileAccess.Read))
                {
                    channelsToBeReturned = (List<Channel>)xmlSerializer.Deserialize(inFile);
                }
                return channelsToBeReturned;
            }
            catch (Exception)
            {
                throw new SerializerException("Podcasts.xml", "Kunde inte deserialisera..");
            }
        }
    }
}
