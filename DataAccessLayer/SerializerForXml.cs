using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Models;
using System.Text;

namespace DataAccessLayer
{
    internal class SerializerForXml
    {
        public void Serialize(List<Channel> ChannelList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Channel>));
                using (FileStream outFile = new FileStream("Podcasts.xml", FileMode.Create,
                    FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, ChannelList);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Channel> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Channel>));
                using (FileStream inFile = new FileStream("Podcasts.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<Channel>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message); 
                
            }
        }
    }
}
