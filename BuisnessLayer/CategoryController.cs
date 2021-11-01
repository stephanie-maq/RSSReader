using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Models;

namespace BuisnessLayer
{
    public class CategoryController
    {
        private IRepository<Category> repo;

        public CategoryController()
        {
            repo = new CategoryRepository();
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
    }
}
