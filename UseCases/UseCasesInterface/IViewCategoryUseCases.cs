using CoreBuisness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewCategoryUseCases
    {
        IEnumerable<Category> Execute();
    }
}