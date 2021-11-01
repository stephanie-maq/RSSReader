using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DataAccessLayer;
using Models;

namespace BuisnessLayer
{
    public class CategoryController
    {
        private string saveFilePath;
        private IRepository<Category> repo;

        public CategoryController(string path)
        {
            repo = new CategoryRepository();

            if (Validation.FileExists(path))
            {
                repo.Load(path);
            }
            else
            {
                string json = "[]";
                File.WriteAllText(path, json);
            }

            saveFilePath = path;
        }

        public List<Category> GetAllCategories()
        {
            return repo.GetAll();
        }

        public void AddNewCategory(string name)
        {
            bool exists = repo.GetAll().Exists(category => category.Name.Equals(name));

            if (exists)
            {
                throw new CustomExceptions.ItemAlreadyExistsException("Kategorin finns redan!");
            }
            else
            {
                repo.Create(new Category(name));
            }
        }

        public void LoadFromFile()
        {
            repo.Load(saveFilePath);
        }

        public void UpdateCategoryTitle(string oldCategory, string newCategory)
        {

            repo.GetAll().ForEach(category =>
            {
                if (category.Name.Equals(oldCategory))
                {
                    category.Name = newCategory;
                }
            });
        }

        public void RemoveCategoryByName(string name)
        {
            List<int> toDelete = new List<int>();

            repo.GetAll().ForEach(category =>
            {
                if (category.Name.Equals(name))
                {
                    int index = repo.GetIndex(category);
                    toDelete.Add(index);
                }
            });

            toDelete.ForEach(index => repo.Delete(index));
        }

        public void SaveAllCategories()
        {
            repo.Save(saveFilePath);
            repo.GetAll().ForEach(category => category.IsSaved = true);
        }

        public bool IsAllSaved()
        {
            foreach (var item in repo.GetAll())
            {
                if (!item.IsSaved)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
