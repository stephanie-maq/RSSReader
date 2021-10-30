using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DataAccessLayer.Repositories;

namespace BuisnessLayer
{
    public class CategoryController
    {
        ICategoryRepository<Category> categoryRepository;
        ChannelRepository channelRepository = new ChannelRepository();

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }

        public void DeleteCategory(string name)
        {
            int index = categoryRepository.GetIndex(name);
            categoryRepository.Delete(index);
        }

        public void CreateCategory(string name)
        {
            // Category newCategory = null;

            Category newCategory = new Category(name);

            categoryRepository.Create(newCategory);
        }

        public List<Category> GetAllCategories()
        {
            return categoryRepository.GetAll();
        }




    }
}
