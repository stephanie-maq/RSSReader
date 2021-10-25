using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface IRepository<T> where T : class
    {
        T FetchFromUrl(string url);
    }
}
