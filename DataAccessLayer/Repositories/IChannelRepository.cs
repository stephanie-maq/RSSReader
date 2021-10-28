using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DataAccessLayer.Repositories
{
    public interface IChannelRepository<T> : IRepository<T> where T : Channel
    {
        T GetByName(string name);

        T GetByUrl(string url);
        int GetIndex(string name);

    }
}
