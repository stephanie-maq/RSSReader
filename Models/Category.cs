using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Category
    {
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }

        public Category()
        {

        }
    }
}
