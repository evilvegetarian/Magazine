using CoreBuisness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewCategoryUseCase
    {
        public IEnumerable<Category> Execute();
    }
}