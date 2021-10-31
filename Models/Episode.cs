using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Episode : Item
    {
        public Episode(string title, string description)
        {
            base.Title = title;
            base.Description = description;
        }
    }
}
