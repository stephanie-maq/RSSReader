using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Episode : Item
    {
        private string name;
        private string descritpion;

        public Episode(string name, string descritpion)
        {
            this.name = name;
            this.descritpion = descritpion;
        }
    }
}
