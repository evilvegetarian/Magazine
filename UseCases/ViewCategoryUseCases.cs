using CoreBuisness;
using System.Collections.Generic;

namespace UseCases
{
    public class ViewCategoryUseCases : IViewCategoryUseCases
    {
        private readonly ICategoryRepository categoryRepository;

        public ViewCategoryUseCases(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }


        public IEnumerable<Category> Execute()
        {
            return categoryRepository.GetCategories();
        }
    }
}
