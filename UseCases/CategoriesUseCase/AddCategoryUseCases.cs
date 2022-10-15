using CoreBuisness;

namespace UseCases
{
    public class AddCategoryUseCases : IAddCategoryUseCases
    {
        private readonly ICategoryRepository categoryRepository;

        public AddCategoryUseCases(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Execute(Category category)
        {
            categoryRepository.AddCategory(category);
        }

    }
}
