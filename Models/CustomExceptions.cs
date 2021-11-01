using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class CustomExceptions
    {
        public class ItemAlreadyExistsException : Exception
        {
            public ItemAlreadyExistsException() { }
            public ItemAlreadyExistsException(string msg) : base(msg) { }
        }
    }
}
