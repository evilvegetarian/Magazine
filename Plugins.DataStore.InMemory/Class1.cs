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
        }

        public IEnumerable<Category> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
