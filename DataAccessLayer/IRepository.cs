﻿using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Save();
        void Delete(int index);
        int GetIndex(string title);
        List<T> GetAll();
    }
}

