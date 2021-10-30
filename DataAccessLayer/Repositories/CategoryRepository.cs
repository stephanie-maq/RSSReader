using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryRepository<Category>
    {
        SerializerForXml<Category> dataManager;
        List<Category> listOfCategories;
        public CategoryRepository()
        {
            dataManager = new SerializerForXml<Category>();
            listOfCategories = new List<Category>();
            listOfCategories = GetAll();
        }

        public void Create(Category entity)
        {
            listOfCategories.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            listOfCategories.RemoveAt(index);
            SaveChanges();
        }

        public List<Category> GetAll()
        {
            List<Category> listOfCategoriesDeserialized = new List<Category>();
            try
            {
                listOfCategoriesDeserialized = dataManager.Deserialize();
            }
            catch (Exception)
            {


            }

            return listOfCategoriesDeserialized;
        }



        public void SaveChanges()
        {
            dataManager.Serialize(listOfCategories);
        }

        public void Update(int index, Category entity)
        {
            if (index >= 0)
            {
                listOfCategories[index] = entity;
            }
            SaveChanges();
        }

        public int GetIndex(string name)
        {
            return GetAll().FindIndex(e => e.Name.Equals(name));
        }



    }
}
