using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Save(string path);
        void Delete(int index);
        int GetIndex(string title);
        List<T> GetAll();
        Task<T> FetchRemoteData(string url);
    }
}

