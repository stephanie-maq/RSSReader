using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Episode
    {
        //private string name;
        //private string descritpion;
        public string Name { get; set; }
        public string Description { get; set; }

        public Episode(string name, string descritpion)
        {
            Name = name;
            Description = descritpion;
        }

        public Episode()
        {

        }

        //public string GetName()
        //{
        //    return name;
        //}
    }
}
