using CoreBuisness;
using System.Collections.Generic;

namespace UseCases
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
    }
}