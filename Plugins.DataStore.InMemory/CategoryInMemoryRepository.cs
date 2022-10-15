using CoreBuisness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            //добавить категории

            categories = new List<Category>()
            {
                new Category{CategoryId=1, Name= "name", Description="desc"},
                new Category{CategoryId=2, Name= "name2", Description="desc2"},
                new Category{CategoryId=3, Name= "name3", Description="desc3"},
            };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase)))
                return;
            var maxId = categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;
            categories.Add(category);
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }

        }
    }
}
