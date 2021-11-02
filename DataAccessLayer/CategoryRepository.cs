using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer
{
    public class CategoryRepository : IRepository<Category>
    {
        List<Category> categories;

        public CategoryRepository()
        {
            categories = new List<Category>();
        }

        public void Create(Category entity)
        {
            categories.Add(entity);
        }

        public void Delete(int index)
        {
            categories.RemoveAt(index);
        }


        public List<Category> GetAll()
        {
            return categories;
        }

        public int GetIndex(Category cat)
        {
            return categories.FindIndex(elem => elem.Name.Equals(cat.Name));
        }

        public void Load(string path)
        {
            string json = File.ReadAllText(path);
            List<Category> cats = JsonSerializer.Deserialize<List<Category>>(json);
            categories = new List<Category>(cats);
        }

        public void Save(string path)
        {
            string json = JsonSerializer.Serialize(categories);
            File.WriteAllText(path, json);
        }

        public void SetAll(List<Category> l)
        {
            categories = l;
        }
    }
}
