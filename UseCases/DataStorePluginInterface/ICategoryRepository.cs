using CoreBuisness;
using System.Collections.Generic;

namespace UseCases
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
    }
}