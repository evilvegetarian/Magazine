using CoreBuisness;
using System;
using System.Collections.Generic;
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

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}
