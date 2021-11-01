using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRemoteRepository<T> : IRepository<T> where T : class
    {
        Task<T> FetchRemoteData(string url);
    }
}
