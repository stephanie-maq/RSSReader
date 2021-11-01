using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BuisnessLayer
{
    public class Validation
    {
        public static bool FileExists(string path)
        {
            return File.Exists(path);
        }
    }
}
