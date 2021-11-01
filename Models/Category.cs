using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Category
    {
        public Category(string name)
        {
            Name = name;
        }

        public String Name { get; set; }
        public bool IsSaved { get; set; }
    }
}
