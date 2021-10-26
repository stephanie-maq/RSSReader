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
        public void Serialize(List<Podcast> podcastList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream outFile = new FileStream("Podcasts.xml", FileMode.Create,
                    FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, podcastList);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Podcast> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream inFile = new FileStream("Podcasts.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<Podcast>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message); 
                
            }
        }
    }
}
