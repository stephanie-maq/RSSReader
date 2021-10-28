using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface IRepository<T> where T : class
    {
        T FetchFromUrl(string url);
        void Create(T entity);
        void Delete(int index);
        void Update(int index, T entity);
        void SaveChanges();
        List<T> GetAll();
    }
}
