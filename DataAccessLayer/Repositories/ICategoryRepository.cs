using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DataAccessLayer.Repositories
{
    public interface ICategoryRepository<T> : IRepository<T> where T : Category
    {
        //T GetByName(string name);

        //T GetByUrl(string url);
        int GetIndex(string name);

    }
}